using Air.Models.DB;
using Microsoft.EntityFrameworkCore;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Air.Models.Helpers
{
    public class XLSFileCreator
    {

        private readonly Storage _storage;

        public XLSFileCreator(DbContextOptions<AppCtx> options)
        {
            _storage = new Storage(options);

        }

        public void WriteToXls(DB.City city)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                IWorkbook workbook = application.Workbooks.Create(1);
                IWorksheet worksheet = workbook.Worksheets[0];

                //Import the data to worksheet
                IList<DB.AQData> reports = _storage.GetDataByCity(city);
                worksheet.ImportData(reports, 2, 1, true);

                //Saving the workbook as stream
                FileStream stream = new FileStream("ImportFromDT.xlsx", FileMode.Create, FileAccess.ReadWrite);
                workbook.SaveAs(stream);
                stream.Dispose();
            }
        }
    }
}
