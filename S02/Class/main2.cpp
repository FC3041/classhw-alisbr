#include<iostream>
#include<math.h>
using namespace std;

class Point
{
    
    
    
    
    public:
        double x;
        double y;
        Point (Point* q)
        {
            x=q->x;
            y=q->y;
        }
        Point(double t, double r)
        {
        x=t;
        y=r;
        }

        Point (double )
        void print_point()
        {
            cout << "x: " <<x << ", y:" << y<<endl;
        }
};

void print_point(Point p)
{
    cout << "x: " <<p.x << ", y:" << p.y<<endl;
}

double points_distance(Point q, Point w)
{
    double x_diff = q.x - w.x;
    double y_diff = q.y - w.y;
    return sqrt(x_diff*x_diff + y_diff*y_diff);
}


int main()
{
    Point p1;
    p1.x = 4;
    p1.y = 5;

    Point p2;
    p2.x=5;
    p2.y=10;

    cout << p1.x <<endl;
    
    int a;
    cin>>a;
    cout<<"a:" <<a<<std::endl;
}