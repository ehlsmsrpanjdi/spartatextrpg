using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta.NameSpace
{
    public static class Key
    {
        public static void AnyKey()
        {
            Console.WriteLine("아무키나 누르시오");
            Console.ReadKey();
        }

        public static void WrongKey()
        {
            Console.WriteLine("잘못된 입력입니다.  아무키나 누르시오");
            Console.ReadKey();
        }
    }


    public static class FieldName
    {
        public const string MainField = "main";
        public const string Shop = "shop";
        public const string Inn = "inn";
        public const string BattleField = "battlefield";
        public const string EncounterField = "encounterField";
    }


    public static class Global
    {
        public static Random rand = new Random();
    }
}
