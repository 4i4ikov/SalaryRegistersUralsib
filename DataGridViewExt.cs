﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pressF
{
    public static class DataGridViewExt
    {
        public static Dictionary<string, string> GetCellsPls (this DataGridView D)
        {

            Dictionary<string,string> ms = new Dictionary<string, string>();

            for (int i = 0; i < D.GetCellCount(DataGridViewElementStates.Selected); i++)
            {
                if (!(ms.ContainsKey(D.SelectedCells[i].OwningColumn.DataPropertyName.ToString()))){
                    ms.Add(D.SelectedCells[i].OwningColumn.DataPropertyName.ToString(), D.SelectedCells[i].Value.ToString());
                }
                
            }
            return ms;
        }
    }
}
