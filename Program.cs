using System;

namespace cs_0915_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "コンピュータ 情報 専門 学校";
            str = str.Replace("情報", "Information");

            // ****************************
            // ヒアドキュメント
            // ****************************
            string html = @"
            <html>
            <body>
                <h1>$01</h1>
            </body>
            </html>";
            html = html.Replace( "$01", str );
            print(html);

            // ****************************
            // $ で埋め込み
            // ****************************
            html = $@"
            <html>
            <body>
                <h1>{str}</h1>
            </body>
            </html>";
            print(html);

        }

        private static void print(string v)
        {
            Console.WriteLine(v);
        }
    }
}
