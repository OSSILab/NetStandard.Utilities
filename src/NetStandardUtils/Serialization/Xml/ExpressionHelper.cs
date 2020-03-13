using System;
using System.Linq.Expressions;
using System.Reflection;

namespace NetStandardUtils.Serialization.Xml
{
    static class ExpressionHelper
    {
        public static void GetPropertyInfo(Expression expression, out string propertyName, out PropertyInfo propertyInfo)
        {
            if (expression.NodeType == ExpressionType.Lambda)
            {
                LambdaExpression lambdaExpression = (LambdaExpression)expression;
                if (lambdaExpression.Body.NodeType == ExpressionType.MemberAccess)
                {
                    MemberExpression memberExpression = (MemberExpression)lambdaExpression.Body;
                    propertyName = memberExpression.Member.Name;
                    propertyInfo = (PropertyInfo)memberExpression.Member;
                    return;
                }
            }
            throw new Exception($"Unsupported Expression:{expression.NodeType}");
        }
    }
}