using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet;
namespace Cutter_Compensation
{
    public struct Vector
    {
        private decimal x;//
        private decimal y;//

        public decimal X { get => x; set => x = value; }
        public decimal Y { get => y; set => y = value; }

        public Vector(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector(Vector Ini)
        {
            this.x = Ini.X;
            this.y = Ini.Y;
        }
        public void Empty()
        {
            this.x = 0;
            this.y = 0;
        }
        public decimal Length()
        {
            return (decimal)Math.Sqrt((double)(this.x * this.x + this.y * this.y));
        }
    }
    class Cutter
    {
        //计算两向量的 点积 Dot
        public decimal Dot(Vector point1,Vector point2)
        {
            return point1.X * point2.X + point1.Y * point2.Y;
        }
        //判断两向量夹角是否大于180°，大于180°返回真，否则返回假
        public bool AngleLargeThanPi(Vector point1, Vector point2)
        {
            decimal temp = point1.X * point2.Y - point2.X * point1.Y;
            return (temp < 0);
        }
        //获取两向量的夹角 从第一个向量逆时针指向第二个向量的夹角 [0-360]
        public decimal AngleBetweenVector(Vector point1, Vector point2) 
        {
            decimal Result = 0;
            decimal Cos_theta = Dot(point1, point2) / (point1.Length() * point2.Length());
            //范围限制
            if (Math.Abs(Cos_theta - 1.0m) < 0.00001m)
            {
                Cos_theta = 1.0m;
            }
            else if (Math.Abs(Cos_theta + 1.0m) < 0.00001m)
            {
                Cos_theta = -1.0m;
            }
            else if (Math.Abs(Cos_theta) < 0.00001m)
            {
                Cos_theta = 0.0m;
            }
            //计算角度
            if (AngleLargeThanPi(point1, point2))
            {
                Result = 360 - (decimal)(Math.Acos((double)Cos_theta) * 180 / Math.PI);
            }
            else
            {
                Result = (decimal)(Math.Acos((double)Cos_theta) * 180 / Math.PI);
            }
            //角度范围约束
            if (Math.Abs(Result - 360) <= 0.00001m)
            {
                Result = 360.0m;
            }
            else if ((Result > 0.000m) && (Result <= 0.00001m))
            {
                Result = 0.0m;
            }
            else if (Math.Abs(Result - 90) <= 0.00001m)
            {
                Result = 90.0m;
            }
            else if (Math.Abs(Result - 180) <= 0.00001m)
            {
                Result = 180.0m;
            }
            else if (Math.Abs(Result - 270) <= 0.00001m)
            {
                Result = 270.0m;
            }
            //返回角度值
            return Result;
        }
        //计算等距线交点
        public Vector Cal_Cross_Point(Vector point1, Vector point2, Vector org_point,decimal distance)
        {
            //先计算角度
            decimal Angle = AngleBetweenVector(point1,point2);
            //在计算交点
            //计算等距线交点
            if (Angle == 180) //角度为180,共线且方向相反
            {
                MessageBox.Show("两直线所在向量夹角为0，数据错误！！");
                return new Vector(0,0);
            }
            else if (Angle == 0) //角度为0,共线
            {
                return new Vector(org_point.X - distance * point1.Y, org_point.Y + distance * point1.X);
            }
            else
            {
                return new Vector(org_point.X + distance * (point2.X - point1.X) / (point1.X * point2.Y - point2.X * point1.Y), org_point.Y + distance * (point2.Y - point1.Y) / (point1.X * point2.Y - point2.X * point1.Y));
            }
        }
    }
}
