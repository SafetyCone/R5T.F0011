using System;


namespace R5T.F0011
{
    public class SyntaxOperator : ISyntaxOperator
    {
        #region Infrastructure

        public static SyntaxOperator Instance { get; } = new();

        private SyntaxOperator()
        {
        }

        #endregion
    }
}
