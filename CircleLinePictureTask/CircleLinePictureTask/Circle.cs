using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CircleLinePictureTask
{
    public abstract class Circle
    {
        //fields
        private double _radius;
        private double _height;
        private int _circleID;
        private string _imageFileName;
        private List<int> _circleList;

        //constructor


        public Circle(double radius, double height, int circleID, string imageFileName)
        {
            _radius = radius;
            _height = height;
            _circleID = circleID;
            _imageFileName = imageFileName;
            _circleList = new List<int>(15);
        }

        //constructor that takes 0 arguments (default constructor)


        public Circle()
        {
            //choose to initialize or not
        }
        public virtual double Radius
        { get { return _radius; } }

        public virtual double Height
        { get { return _height; } }

        public virtual int CircleID
        { get { return _circleID; } }

        public virtual string ImageFileName
        { get { return _imageFileName; } }

        public virtual int[] CircleList
        { get { return _circleList.ToArray(); } }


        //public virtual Image GetPicture()
        //{
        //    return Image.FromFile(_imageFileName);
        //}


        public virtual double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public virtual double Circumference()
        {
            return (2 * Radius) * Math.PI;
        }

    }
}
