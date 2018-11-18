using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


namespace MegaDeskWebApp_Flores_Carranza

{
    public struct Desk
    {
        public decimal widthInput { get; set; }
        public decimal heightInput { get; set; }
        public decimal drawerInput { get; set; }
        public decimal materialNum { get; set; }

        public Desk(decimal widthInput, decimal heightInput, decimal drawerInput, decimal materialNum)
        {

            this.widthInput = widthInput;
            this.heightInput = heightInput;
            this.drawerInput = drawerInput;
            this.materialNum = materialNum;

        }
    }
}