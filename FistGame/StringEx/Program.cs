using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 练习5：123-456---7---89-----123----2把类似的字符串中重复符号”-”去掉，既得到123-456-7-89-123-2. split()、StringSplitOptions.RemoveEmptyEntries   Join()
/// </summary>
namespace StringEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string orinStr = "123 - 456-- - 7-- - 89---- - 123----2";
            string resStr = orinStr.Replace(" ", "");
            Console.WriteLine("去空格：" + resStr);
            var strs = resStr.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("分割：");
            
            foreach(string str in strs)
            {
                Console.WriteLine(str);
            }
            resStr = String.Join("-", strs);
            Console.WriteLine("最终：" + resStr);

            Console.ReadKey();
        }
    }
}
