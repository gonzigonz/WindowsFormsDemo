USE WindowsFormsDemo

BULK INSERT [dbo].[Categories]
FROM 'C:\DATA\GITHUB\WindowsFormsDemo\AppDatabase\Data\Categories.csv' 
WITH 
( 
    FIELDTERMINATOR = '|', 
    ROWTERMINATOR = '\n' 
) 

BULK INSERT [dbo].[Products]
FROM 'C:\DATA\GITHUB\WindowsFormsDemo\AppDatabase\Data\Products.csv' 
WITH 
( 
    FIELDTERMINATOR = '|', 
    ROWTERMINATOR = '\n' 
) 