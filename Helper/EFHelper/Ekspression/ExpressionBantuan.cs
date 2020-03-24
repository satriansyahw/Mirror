using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Ekspression
{
    public class ExpressionBantuan
    {
        private static ExpressionBantuan instance;
        public ExpressionBantuan()
        {
            this.LoadInitialOperatorExpr();
        }
        public static ExpressionBantuan GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ExpressionBantuan();
                return instance;
            }
        }
        public Dictionary<string, InterfaceOperatorExpr> DictOperatorExpr = new Dictionary<string, InterfaceOperatorExpr>();
        private void LoadInitialOperatorExpr()
        {
            DictOperatorExpr.Add("=", new EqualOperatorExpr());
            DictOperatorExpr.Add("<>", new EqualNotOperatorExpr());
            DictOperatorExpr.Add("!=", new EqualNotOperatorExpr());
            DictOperatorExpr.Add("<", new LessThanOperatorExpr());
            DictOperatorExpr.Add("<=", new LessThanOperatorExpr());
            DictOperatorExpr.Add(">", new MoreThanOperatorExpr());
            DictOperatorExpr.Add(">=", new MoreThanOperatorExpr());
            DictOperatorExpr.Add("in", new InOperatorExpr());
            DictOperatorExpr.Add("like", new LikeOperatorExpr());
            DictOperatorExpr.Add("contains", new InOperatorExpr());
            DictOperatorExpr.Add("between", new BetweenOperatorExpr());
            DictOperatorExpr.Add("datetime", new DatetimeExpr());
        }
    }
}
