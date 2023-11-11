CREATE TABLE Students(
    Id INT IDENTITY PRIMARY KEY,
    Name VARCHAR(50),
    BeginDate DATETIME,
    EndDate DATETIME
)

INSERT INTO Students  VALUES('Bahriddin', '2021-10-12', '2025-10-12'),
    ('Jurat', '2022-10-12', '2026-10-12'),
    ('Rustam', '2020-10-12', '2024-10-12'),
    ('Nodir', '2019-10-11', '2023-09-12')


SELECT * FROM Students
GO

-- Task 1
CREATE PROCEDURE OneParametrProcedure

    @Id INT
AS
BEGIN 
    SELECT *  FROM Students WHERE id = @Id
    END


EXEC OneParametrProcedure @Id = 3
GO

-- Task 2

CREATE PROCEDURE BetweenDate
(
    @BeginDate DATETIME,
    @EndDate DATETIME
)
AS
BEGIN 
    SELECT *  FROM Students WHERE BeginDate BETWEEN @BeginDate AND @EndDate
END

EXEC BetweenDate @BeginDate = '2020-10-22', @EndDate = '2021-10-22'
GO

-- Task 3
CREATE PROCEDURE SearchProcedure
    @SearchStr NVARCHAR(100)
AS
BEGIN
    CREATE TABLE #Results (ColumnName NVARCHAR(370), ColumnValue NVARCHAR(3630))

    SET NOCOUNT ON

    DECLARE @TableName NVARCHAR(256), @ColumnName NVARCHAR(128), @SearchStr2 NVARCHAR(110)
    SET @TableName = ''
    SET @SearchStr2 = QUOTENAME('%' + @SearchStr + '%','''')

    WHILE @TableName IS NOT NULL
    BEGIN
        SET @ColumnName = ''
        SET @TableName =
        (
            SELECT MIN(QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME))
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_TYPE = 'BASE TABLE'
                AND QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME) > @TableName
                AND OBJECTPROPERTY(
                        OBJECT_ID(
                            QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME)
                        ), 'IsMSShipped'
                    ) = 0
        )

        WHILE (@TableName IS NOT NULL) AND (@ColumnName IS NOT NULL)
        BEGIN
            SET @ColumnName =
            (
                SELECT MIN(QUOTENAME(COLUMN_NAME))
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = PARSENAME(@TableName, 2)
                    AND TABLE_NAME = PARSENAME(@TableName, 1)
                    AND DATA_TYPE IN ('char', 'varchar', 'nchar', 'nvarchar', 'int', 'decimal')
                    AND QUOTENAME(COLUMN_NAME) > @ColumnName
            )

            IF @ColumnName IS NOT NULL
            BEGIN
                INSERT INTO #Results
                EXEC
                (
                    'SELECT ''' + @TableName + '.' + @ColumnName + ''', LEFT(' + @ColumnName + ', 3630) FROM ' + @TableName + ' (NOLOCK) ' +
                    ' WHERE ' + @ColumnName + ' LIKE ' + @SearchStr2
                )
            END
        END
    END

    SELECT ColumnName, ColumnValue FROM #Results

    DROP TABLE #Results
END


EXEC [SearchProcedure] @SearchStr = '1'