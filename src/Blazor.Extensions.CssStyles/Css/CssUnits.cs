namespace Blazor.Extensions.CssStyles.Css
{
    public class CssUnits
    {
        public static CssUnits Cm = new CssUnits("cm");
        public static CssUnits Mm = new CssUnits("mm");
        public static CssUnits Inches = new CssUnits("in");
        public static CssUnits Px = new CssUnits("px");
        public static CssUnits Points = new CssUnits("pt");
        public static CssUnits Picas = new CssUnits("pc");
        public static CssUnits Em = new CssUnits("em");
        public static CssUnits Ex = new CssUnits("ex");
        public static CssUnits Ch = new CssUnits("ch");
        public static CssUnits Rem = new CssUnits("rem");
        public static CssUnits VW = new CssUnits("vw");
        public static CssUnits VH = new CssUnits("vh");
        public static CssUnits VMin = new CssUnits("vmin");
        public static CssUnits VMax = new CssUnits("vmax");
        public static CssUnits Percentage = new CssUnits("%");


        public string Symbol { get; }

        private CssUnits(string symbol)
        {
            Symbol = symbol;
        }
    }
}
