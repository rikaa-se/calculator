using System;

namespace Calculator.Enum
{
    /// <summary>
    /// 直前に押下されたボタン種別
    /// </summary>
    public enum ButtonType
    {
        /*
        列挙体は応用的な使い方をするといろいろなことができます。
        例えば、あえて四則演算の値を 101～104 等に設定すると、「押下されたボタンの値が 100 > の場合は四則演算」のような判定ができます。
        一方で、このルールを把握していない状態でこの列挙隊の要素を増やすと、意図しない動作を引き起こす可能性があるので注意が必要です。
        例) 要素に新しく % ボタンを追加した際に、その要素を 105 等の値で設定してしまうと % ボタンも四則演算と間違って判定されてしまう。
        */

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