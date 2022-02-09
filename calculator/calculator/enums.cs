using System;

namespace Calculator.Enum
{
    /// <summary>
    /// 直前に押下されたボタン種別
    /// </summary>
    public enum ButtonType
    {
        /// <summary>
        /// 未設定
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// 加算 
        /// </summary>
        Addition, // 1

        /// <summary>
        /// 減算 
        /// </summary>
        Subtraction, //2

        /// <summary>
        /// 乗算 
        /// </summary>
        Multiplication, //3

        /// <summary>
        /// 除算 
        /// </summary>
        Division, //4

        /// <summary>
        /// 等号
        /// </summary>
        Equal,

        /// <summary>
        /// ピリオド(小数点)
        /// </summary>
        Period,

        /// <summary>
        /// 数値
        /// </summary>
        Numeric,
    }
}
