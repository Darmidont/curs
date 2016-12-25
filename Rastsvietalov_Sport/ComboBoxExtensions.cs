using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rastsvietalov_Sport;

namespace CourseVasilets
{
    class ComboboxExtensions
    {
    }

    class TypeComboObject
    {
        public int Id;
        public string Name;

        public TypeComboObject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        //public static void GetFromDBtoCombo(DB_Sport_MainDataSet.TypesDataTable table, ComboBox owner)
        //{
        //    foreach (DB_Sport_MainDataSet.TypesRow typesRow in table)
        //    {
        //        owner.Items.Add(new TypeComboObject(typesRow.TypeId, typesRow.TName));
        //    }
        //}
    }

    class ManufacturerComboObject
    {
        public int Id;
        public string Name;
        public string Country;

        public ManufacturerComboObject(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return Name + " | " + Country;
        }

    }
}
