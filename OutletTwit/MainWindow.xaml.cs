using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OutletTwit
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ウィンドウの状態（最大化、最小化）が変わったときに発生するイベントです。
        /// WindowChromeのフレーム描画に伴うウィンドウサイズのずれを修正します。
        /// </summary>
        /// <param name="sender">イベントの呼び出し元</param>
        /// <param name="e">イベント引数</param>
        private void OnWindowStateChanged(object sender, EventArgs e)
        {
            // 現在のウィンドウ状態により分岐
            switch (WindowState)
            {
                case WindowState.Maximized: // 最大化されたとき
                    LayoutRoot.Margin = new Thickness(7); // レイアウトルート（Grid）に7pxの余白を与える
                    break;

                default: // それ以外のとき
                    LayoutRoot.Margin = new Thickness(0); // 余白を0pxにする
                    break;
            }
        }
    }
}
