﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGridForGeoTopo
{
    public class SettingsConverter : StringConverter
    {
        private List<string> deleteOption = new List<string>();

        public SettingsConverter()
        {
            deleteOption.Add("Yes");
            deleteOption.Add("No");
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            //true means show a combobox
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            //true will limit to list. false will show the list, but allow free-form entry
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(deleteOption);
        }
    }
}
