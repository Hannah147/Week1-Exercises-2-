using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Exercises
{
    public class Album
    {
        public string AlbumName { get; set; }
        public DateTime YearReleased { get; set; }
        public int AlbumSales { get; set; }

        public override string ToString()
        {
            return $"{AlbumName}"+
                $"Year Released : {YearReleased}" +
                $"Sales : {AlbumSales}";
        }
    }
}
