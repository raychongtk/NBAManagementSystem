using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA1
{
    class lib
    {
        public static NBAEntities entity = new NBAEntities();

        public static void redirect(Form newForm, Form self)
        {
            newForm.Owner = self;
            newForm.Show();
            self.Hide();
        }

        public static Image toImage(byte[] bytes)
        {
            if (bytes == null)
                return Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"person.png");
            return (Image)(new ImageConverter().ConvertFrom(bytes));
        }

        public static void fillCombo(Dictionary<int, string> source, ComboBox cbo)
        {
            cbo.DataSource = new BindingSource(source, null);
            cbo.ValueMember = "key";
            cbo.DisplayMember = "value";
        }
        public static void fillCombo(Dictionary<string, string> source, ComboBox cbo)
        {
            cbo.DataSource = new BindingSource(source, null);
            cbo.ValueMember = "key";
            cbo.DisplayMember = "value";
        }

        public static object getProperty(object obj,int index)
        {
            return obj.GetType().GetProperties()[index].GetValue(obj, null); 
        }
        public static string getStatus(int status)
        {
            switch (status)
            {
                case -1:
                    return "Not Start";
                case 0:
                    return "Running";
                default:
                    return "Finished"; 
            }
        }

        public static string getQuarter(int q)
        {
            switch (q)
            {
                case 1:
                    return "1st";
                case 2:
                    return "2nd";
                case 3:
                    return "3rd";
                case 4:
                    return "4th";
                default:
                    return "OT" + (q - 4);
            }
        }
    }
}
