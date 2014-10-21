set sqlServer=localhost
set outputDir=Z:\Documents\Visual Studio 2013\Projects\WindowsFormsDemo\AppDatabase

bcp WindowsFormsDemo.dbo.Categories out "%outputDir%\Categories.csv" -t"|" -T -c -S%sqlServer%
bcp WindowsFormsDemo.dbo.Products out "%outputDir%\Products.csv" -t"|" -T -c -S%sqlServer%