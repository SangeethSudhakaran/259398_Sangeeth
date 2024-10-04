using ClosedXML.Excel;

namespace FoodDeliveryManagement
{
    public class ExcelHandler
    {
        //Create new excel file
        public static void CreateExcelFile(string filePath)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Restaurants");

            worksheet.Cell(1, 1).Value = "Name";
            worksheet.Cell(1, 2).Value = "Address";
            worksheet.Cell(1, 3).Value = "Rating";

            worksheet.Cell(2, 1).Value = "Pasta House";
            worksheet.Cell(2, 2).Value = "456 Elm St";
            worksheet.Cell(2, 3).Value = 4.2;

            worksheet.Cell(3, 1).Value = "Pizza Place";
            worksheet.Cell(3, 2).Value = "123 Main St";
            worksheet.Cell(3, 3).Value = 4.5; 
            workbook.SaveAs(filePath);
            Console.WriteLine("Excel file created: " + filePath);
        }

        //Read data from excel file
        public static void ReadExcelFile(string filePath)
        {
            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet("Restaurants");

            for (int row = 2; row <= worksheet.LastRowUsed().RowNumber(); row++)
            {
                string name = worksheet.Cell(row, 1).GetString();
                string address = worksheet.Cell(row, 2).GetString();
                double rating = worksheet.Cell(row, 3).GetDouble();

                Console.WriteLine($"Restaurant: {name},\t Address: {address},\t Rating: {rating}");
            }
        }
    }
}
