using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator.Enum;

/// <summary>
/// 電卓
/// </summary>
namespace Calculator
{
    /// <summary>
    /// 電卓画面クラス
    /// </summary>
    public partial class CalculatorForm : Form
    {
        #region *** クラス変数 / プロパティ ***

        /// <summary>
        /// 画面表示値(変数)
        /// Tips:プロパティで画面表示を連動させる副作用を用意するため用意。
        /// </summary>
        private double _displayNumber = 0;
        
        /// <summary>
        /// 画面表示値
        /// </summary>
        private double DisplayNumber 
        {
            get { return _displayNumber; }
            set 
            {
                _displayNumber = value;
                ResultLabel.Text = _displayNumber.ToString();
            }
        }

        /// <summary>
        /// 計算基準値 (演算子→数値ボタン押下時に隠れる内部値) / Null を許可する。
        /// </summary>
        private double? MemoryNumber { get; set; } = null;

        /// <summary>
        /// 直前に押下されたボタン種別
        /// </summary>
        ButtonType ButtonType { get; set; } = ButtonType.Undefined;

        /// <summary>
        /// 直前に押されたボタン四則演算子か否か
        /// </summary>
        private bool IsCalcurator
        { 
            get 
            {
                return ButtonType == ButtonType.Addition
                    || ButtonType == ButtonType.Subtraction
                    || ButtonType == ButtonType.Multiplication
                    || ButtonType == ButtonType.Division;
            } 
        }

        /// <summary>
        /// 最後に押下された演算子の種別
        /// </summary>
        private　ButtonType LastCalculatorSymbol { get; set; } = ButtonType.Undefined;

        #endregion

        #region *** コンストラクタ ***

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        #endregion

        #region *** イベントハンドラ ***

        /// <summary> 
        /// 0～9 ボタンクリック
        /// </summary>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            SetNumber(int.Parse(((Button)sender).Text));
        }

        /// <summary> 
        /// .  ボタンクリック
        /// </summary>
        private void PointButton_Click(object sender, EventArgs e)
        {
            ButtonType = ButtonType.Period;
        }

        /// <summary> 
        /// 足し算（＋）ボタンクリック
        /// </summary>
        private void SumButton_Click(object sender, EventArgs e)
        {
            Calcurate(ButtonType.Addition);
        }

        /// <summary> 
        /// 引き算（ー）ボタンクリック
        /// </summary>
        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            Calcurate(ButtonType.Subtraction);
        }

        /// <summary> 
        /// 掛け算（×）ボタンクリック
        /// </summary>
        private void ProductButton_Click(object sender, EventArgs e)
        {
            Calcurate(ButtonType.Multiplication);
        }

        /// <summary> 
        /// 割り算（÷）ボタンクリック
        /// </summary>
        private void QuotientButton_Click(object sender, EventArgs e)
        {
            Calcurate(ButtonType.Division);
        }

        /// <summary> 
        /// 計算（=）ボタンクリック
        /// </summary>
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            Calcurate(ButtonType.Equal);
        }

        /// <summary> 
        /// クリア（Ｃ）ボタンクリック
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        #endregion

        #region *** Private Method ***

        /// <summary>
        /// 初期化を実施します。
        /// </summary>
        private void Initialize()
        {
            
            ButtonType = ButtonType.Undefined;              // 押下されたボタン種別 を初期化
            LastCalculatorSymbol = ButtonType.Undefined;    // 最後に押下された四則演算種別 を初期化
            DisplayNumber = 0;                              // Display 表示を 0 に設定
            MemoryNumber = null;                            // 計算基準値 を初期化
        }

        /// <summary>
        /// 数値をセットします。
        /// </summary>
        /// <param name="arg">ボタンで押下された入力値</param>
        private void SetNumber(int arg)
        {
            // 直前の押下ボタンが演算子系統である場合
            if (IsCalcurator)
            {
                MemoryNumber = DisplayNumber;   // 現在表示中の値を 計算基準値 に退避し入力値をそのまま画面に出す
                DisplayNumber = arg;            // 表示中の値をディスプレイ値に設定 / 必ず一桁になる (Int -> Double への暗黙の型変換なので本当はあまりよくない)
            }
            // 表示中の値が NaN または ∞の場合
            else if(_displayNumber is double.NaN || _displayNumber is double.PositiveInfinity)
            {
                // 入力値をそのままセット
                DisplayNumber = arg; 
            }
            else
            {
                try
                {
                    // 直前に押下されたボタンが "." かつ、現在表示中の値に小数点がない場合は "."  を付与する。                
                    string tmp = _displayNumber.ToString();
                    if (ButtonType == ButtonType.Period && _displayNumber % 1 == 0) { tmp += "."; }

                    // 実際の入力値を追加
                    tmp += arg.ToString();

                    // 小数点を含まない場合先頭の '0' トリム実施
                    if (tmp.Contains(".")) { tmp.TrimStart('0'); }

                    // double に変換、格納
                    DisplayNumber = double.Parse(tmp);

                    // 上の一連の挙動を1行でやってたけど複雑になりすぎたのでオミット(これに小数点含まない場合の0トリムオミットはきつい)
                    // boolean ? true : false 記法はお勧め () 
                    //DisplayNumber = double.Parse((_displayNumber.ToString() + (ButtonType == ButtonType.Period && _displayNumber % 1 == 0 ? "." : "") + arg.ToString()));

                }
                catch (Exception e)
                {
                    ResultLabel.Text = GetErrorMessage(e);

                    // 本来ならクリアボタンをすべて非制御にする、など
                }
            }

            ButtonType = ButtonType.Numeric;
        }

        /// <summary> 
        /// 四則演算の実施
        /// </summary>
        /// <param name="buttonType">押下されたボタン種別</param>
        private void Calcurate(ButtonType buttonType)
        {
            try
            {
                // 計算基準値が存在する場合、演算を実施する
                if (MemoryNumber != null)
                {
                    switch (LastCalculatorSymbol)
                    {
                        case ButtonType.Addition:
                            DisplayNumber = (double)MemoryNumber + DisplayNumber;
                            break;
                        case ButtonType.Subtraction:
                            DisplayNumber = (double)MemoryNumber - DisplayNumber;
                            break;
                        case ButtonType.Multiplication:
                            DisplayNumber = (double)MemoryNumber * DisplayNumber;
                            break;
                        case ButtonType.Division:
                            DisplayNumber = (double)MemoryNumber / DisplayNumber;
                            break;
                        default:
                            // 通常は入ることはないが一応入れる。
                            // 実際に例外は発生していないが、異常事態なので例外をスロー
                            throw new Exception("演算子の判定異常");
                    }

                    // 表示中の内容を 計算基準値 に複写
                    MemoryNumber = null;
                }
                else
                {
                    MemoryNumber = DisplayNumber;
                }

                // 直前に押下されたボタン内容を保存
                ButtonType = buttonType;
                if (IsCalcurator)
                {
                    // 四則演算系統であればそれも保持
                    LastCalculatorSymbol = ButtonType;
                }

            }
            catch (DivideByZeroException e)
            {
                // 0 で割ってもここに入らないことが判明(びっくり)
                ResultLabel.Text = "ゼロで割ることはできません。 / " + e.Message;

                // 本来ならクリアボタンをすべて非制御にする、など
            }
            catch (Exception e)
            {
                ResultLabel.Text = GetErrorMessage(e);
                
                // 本来ならクリアボタンをすべて非制御にする、など
            }
        }

        /// <summary>
        /// 例外内のエラーメッセージを再帰的に取得し、 / で連結します。
        /// </summary>
        /// <param name="e">例外</param>
        /// <returns></returns>
        private string GetErrorMessage (Exception e)
        {
            string ret = e.Message;
            if(e.InnerException != null)
            {
                // InnnerException が存在する場合、自身(GetErrorMessage() を呼び出す)
                ret += " / " + GetErrorMessage(e.InnerException);
            }

            return ret;
        }

        #endregion
    }
}
