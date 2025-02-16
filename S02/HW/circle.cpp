#include <iostream>
#include <cmath>
#include <math.h>
using namespace std;

class Circle {
public:
    double x, y, r;

    Circle(double x_center, double y_center, double radius) {
        x = x_center;
        y = y_center;
        r = radius;
    }

    int check(double px, double py) {
        double distance = sqrt((px-x)*(px-x) + (py-y)*(py-y));
        if (distance <= r) {
            return 1;
        } else {
            return 0;
        }
    }    
};

int main() {
    double cx, cy, radius;
    cin >> cx >> cy;
    cin >> radius;

    Circle circle(cx, cy, radius);
    double px, py;
    cin >> px >> py;

    int result = circle.check(px, py);
    if (result == 1) {
        cout << "inside" << endl;
    } else {
        cout << "outside" << endl;
    }
    return 0;
}
