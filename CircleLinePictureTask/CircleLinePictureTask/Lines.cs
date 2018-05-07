using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CircleLinePictureTask
{
    public abstract class Lines
    {
        
            //fields
            private double _length;
            public int _lineID;
            private string _imageFileName;
            private List<int> _lineList;

            //constructor

            public Lines(double length, int lineID, string imageFileName)
            {
                _length = length;
                _lineID = lineID;
                _imageFileName = imageFileName;

                _lineList = new List<int>(15);
            }

            //constructor that takes 0 arguments (default constructor)
            public Lines()
            {
                //choose to initialize or not
            }
            public virtual double Length
            { get { return _length; } }

            public virtual int LineID
            { get { return _lineID; } }

            public virtual string ImageFileName
            { get { return _imageFileName; } }

            public virtual int[] LineList
            { get { return _lineList.ToArray(); } }


            //public virtual Image GetPicture()
            //{
            //    return Image.FromFile(_imageFileName);
            //}

            public virtual double Long()
            {
                return _length;
            }
        }
    }

