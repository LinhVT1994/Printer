using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    /// <summary>
    /// This comment is created by the company computer.
    /// </summary>
    class Printer
    {


        private double _InkAmount = 100;　         //　インク量.
        private int _PrintingPaperAmount = 50;  //　印刷紙の枚数.
        private int _TotalPrintedSheets = 0;　  //　総印刷枚数.
        private string _MakerName = null;          //　メーカー名.
        private string _Model = null;              //  型番.

        public static Printer GetInstance(string makerName, string modelNumber)
        {
            if (makerName == null || modelNumber == null)
            {
                return null;
            }
            return new Printer(makerName, modelNumber);
        }
        public Printer(string makerName, string modelNumber)
        {
            MakerName = makerName;
            Model = modelNumber;
        }

        public string GetStatus()
        {
            //インク量, 印刷紙の枚数, 総印刷枚数とかの情報を含んで返します。
            return string.Format("Ink Amount: {0} Printing Paper Amount: {1} Total Printed Sheets: {2}", InkAmount, PrintingPaperAmount, TotalPrintedSheets);
        }
        /// <summary>
        /// 印刷.
        /// </summary>
        public bool Print()
        {
            if (InkAmount <= 0 && PrintingPaperAmount <= 0)
            {
                return false;
            }
            InkAmount -= 3;
            PrintingPaperAmount -= 1;
            TotalPrintedSheets += 1;
            return true;
        }

        #region Declare properties
        /// <summary>
        /// インク量.
        /// </summary>
        public double InkAmount
        {
            get
            {
                return _InkAmount;
            }
            set
            {
                _InkAmount = value;
            }
        }
        /// <summary>
        /// 印刷紙の枚数..
        /// </summary>
        public int PrintingPaperAmount
        {
            get
            {
                return _PrintingPaperAmount;
            }
            set
            {
                _PrintingPaperAmount = value;
            }
        }
        /// <summary>
        /// 総印刷枚数.
        /// </summary>
        public int TotalPrintedSheets
        {
            get
            {
                return _TotalPrintedSheets;
            }
            set
            {
                _TotalPrintedSheets = value;
            }
        }
        /// <summary>
        /// メーカー名.
        /// </summary>
        public string MakerName
        {
            get
            {
                return _MakerName;
            }
            set
            {
                _MakerName = value;
            }
        }
        /// <summary>
        /// 型番.
        /// </summary>
        public string Model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
            }
        }
        #endregion
    }
}
