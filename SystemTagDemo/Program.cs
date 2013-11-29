using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Customization.Tagging;
using FISCA;

namespace SystemTagDemo
{
    public static class Program
    {
        [MainMethod]
        public static void Main()
        {
            /*
             * catalog 有四種：Student、Class、Teacher、Course
             * tagFullName Tag 全名。
             * color 顏色。
             * code 權限代碼。
             * title 在權限管理畫面上要顯示的標題。
             * path 在權限管理畫面放置的路徑。
             * */
            SystemTag.Define("Teacher", "角色:決策人員", Color.Red, "Role.0001", "設定「決策人員」", "系統>角色");

            //注意：如果在畫面上找不到所定議的 Tag，可能是權限還沒有開的關係。

        }
    }
}
