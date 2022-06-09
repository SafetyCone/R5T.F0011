using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace R5T.F0011
{
    public partial interface ISyntaxOperator
    {
        public TParentNode AddNode<TParentNode, TNode>(
            TParentNode parentNode,
            TNode node,
            Func<TParentNode, TNode, TParentNode> addSimple,
            out SyntaxAnnotation annotation)
            where TParentNode : SyntaxNode
            where TNode : SyntaxNode
        {
            var annotatedNode = node.Annotate_Untyped(out annotation);

            var output = addSimple(parentNode, annotatedNode);
            return output;
        }
    }
}