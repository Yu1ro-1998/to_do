//usingは上に固めるのがセオリー
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace practice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //3.2.6.6 コレクションのデータバインディング//
        private ObservableCollection<to_do> to_Dos { get; } = new ObservableCollection<to_do>();


        public MainPage()
        {
            InitializeComponent();
            this.listView.ItemsSource = this.to_Dos;
        }

        //追加ボタンの挙動　元々system.EventArgs eだったが上でusing systemしているので名前空間省略可能
        private void ButtonAddItem_Clicked(object sender, EventArgs e)
        {
            this.to_Dos.Add(new to_do { Name = this.entry.Text });
        }

        public class to_do
        {
            public string Name { get; set; } //{ get; set; }がよくわからない　→　自動実装プロパティ　https://www.ipentec.com/document/csharp-auto-implemented-property　アクセサ(別のクラスからメンバ変数にアクセスできる。)
        }



        //削除ボタンの挙動
        private void ButtonRemoveItem_Clicked(object sender, EventArgs e)
        {


        }






    }
}
