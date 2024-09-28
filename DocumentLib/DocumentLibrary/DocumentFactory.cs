using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLibrary
{
    public class DocumentFactory
    {
        public static Report CreateReport(string[] fileData)
        {
            Report item1 = new Report();
            item1.Name = fileData[1];
            item1.Description = fileData[2];
            item1.Content = fileData[3];
            string[] param = fileData[4].Split();
            item1.ShelfTime = new DateOnly(int.Parse(param[2]), int.Parse(param[1]), int.Parse(param[0]));
            item1.IsAccepted = Convert.ToBoolean(fileData[5]);
            item1.SignedBy = fileData[6];

            return item1;
        }

        public static Statement CreateStatement(string[] fileData)
        {
            Statement item2 = new Statement();
            item2.Name = fileData[1];
            item2.Description = fileData[2];
            item2.Content = fileData[3];
            string[] param1 = fileData[4].Split();
            item2.ShelfTime = new DateOnly(int.Parse(param1[2]), int.Parse(param1[1]), int.Parse(param1[0]));
            item2.SignedBy = fileData[5];

            return item2;
        }

        public static Memo CreateMemo(string[] fileData)
        {
            Memo item3 = new Memo();
            item3.Name = fileData[1];
            item3.Description = fileData[2];
            item3.Content = fileData[3];
            item3.IsDone = Convert.ToBoolean(fileData[4]);
            string[] param2 = fileData[5].Split();
            item3.ShelfTime = new DateOnly(int.Parse(param2[2]), int.Parse(param2[1]), int.Parse(param2[0]));

            return item3;
        }
    }
}
