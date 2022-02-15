using System;
using System.Windows.Forms;

namespace calculator
{

    /// <summary>
    /// 電卓画面クラス
    /// </summary>
    public partial class CalculatorForm : Form
    {

        // 計算結果
        double _result = 0; 

        // 最後に押された演算ボタン
        string _operator = "";

        // 結果表示ラベルのクリアフラグ
        bool _clearFlag = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 0～9 ボタンクリック
        /// </summary>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            // 前に演算ボタン押されてる場合はは表示ラベルクリア
            if (_clearFlag == true) {
                ResultLabel.Text = "";
                _clearFlag = false;
            }

            // 結果表示
            if (ResultLabel.Text.IndexOf(".") > 0) {
                // 小数点ありの場合はそのまま追加
                ResultLabel.Text += ((Button)sender).Text;
            } else {
                // 整数の場合の先頭0を削除
                ResultLabel.Text = ResultLabel.Text.TrimStart(new Char[] { '0' }) + ((Button)sender).Text;
            }
        }

        /// <summary> 
        /// .  ボタンクリック
        /// </summary>
        private void PointButton_Click(object sender, EventArgs e)
        {
            // すでに「.」があればここで抜ける
            if(ResultLabel.Text.IndexOf(".") > 0) { return; }

            // 結果ラベルへ「.」を追加表示
            ResultLabel.Text += ".";
        }

        /// <summary> 
        /// 足し算（＋）ボタンクリック
        /// </summary>
        private void SumButton_Click(object sender, EventArgs e)
        {
            ResultData("+");
        }

        /// <summary> 
        /// 引き算（ー）ボタンクリック
        /// </summary>
        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            ResultData("-");
        }

        /// <summary> 
        /// 掛け算（×）ボタンクリック
        /// </summary>
        private void ProductButton_Click(object sender, EventArgs e)
        {
            ResultData("*");
        }

        /// <summary> 
        /// 割り算（÷）ボタンクリック
        /// </summary>
        private void QuotientButton_Click(object sender, EventArgs e)
        {
            ResultData("/");
        }

        /// <summary> 
        /// 計算（=）ボタンクリック
        /// </summary>
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            ResultData("=");
            _operator = "";
            _result = 0;
        }

        /// <summary> 
        /// クリア（Ｃ）ボタンクリック
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            _operator = "";
            _result = 0;
            ResultLabel.Text = "0";
        }

        /// <summary> 
        /// 四則演算処理メソッド
        /// </summary>
        /// <param name="operatorButton">押されたボタン(+-*/=)</param>
        private void ResultData(string operatorButton)
        {
            // 数値に変換
            double result = 0;
            double number = double.Parse(ResultLabel.Text);

            // 連続して演算ボタンは押された場合はここで抜ける
            if (_clearFlag) {
                return;
            }
            
            // 計算条件が揃っている場合は計算して表示する
            if (number != 0 && _result != 0 && _operator != "") {
                switch (_operator)
                {
                    case "+":
                        result = _result + number;
                        break;
                    case "-":
                        result = _result - number;
                        break;
                    case "*":
                        result = _result * number;
                        break;
                    case "/":
                        result = _result / number;
                        break;
                }
                ResultLabel.Text = result.ToString();
            } else  {
                result = number;
            }

            // 変数へ設定
            _result = result;
            _operator = operatorButton;
            _clearFlag = true;
        }
    }
}
