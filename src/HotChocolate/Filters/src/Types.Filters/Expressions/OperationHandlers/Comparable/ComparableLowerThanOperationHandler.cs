using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace HotChocolate.Types.Filters.Expressions;

[Obsolete("Use HotChocolate.Data.")]
public sealed class ComparableLowerThanOperationHandler
    : ComparableOperationHandlerBase
{
    protected override bool TryCreateExpression(
        FilterOperation operation,
        Expression property,
        Func<object> parseValue,
        [NotNullWhen(true)] out Expression? expression)
    {
        switch (operation.Kind)
        {
            case FilterOperationKind.LowerThan:
                expression = FilterExpressionBuilder.LowerThan(
                    property, parseValue());
                return true;

            case FilterOperationKind.NotLowerThan:
                expression = FilterExpressionBuilder.Not(
                    FilterExpressionBuilder.LowerThan(
                        property, parseValue()));
                return true;

            default:
                expression = null;
                return false;
        }
    }
}