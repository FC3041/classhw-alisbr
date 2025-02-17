#include <iostream>
class student
{
public:
    int m_stdnumber;
    char m_firstname[20];
    char m_lastname[20];
    double m_coursespassed;
    int m_credits[40];
    double m_grades[40];
    char* m_coursenames[40];

    double getGPA()
    {
        double sumgrade=0;
        int sumcredit=0;
        for(int i=0;i<m_coursespassed;i++)
        {
            sumgrade+=m_credits[i]*m_grades[i];
            sumcredit+=m_credits[i];

        }
        return sumgrade/sumcredit;
    }

    void list_courses()
    {
        for(int i =0;i<m_coursespassed;i++)
        {
            std::cout <<m_coursenames[i]<<": "
                      <<m_credits[i] << " : "
                      << m_grades[i] << std::endl;
        }
    }

    void register_course(int credits,const char* name, double grades)
    {
        m_credits[m_coursespassed]= credits;
        m_grades[m_coursespassed]= grades;
        m_coursenames[m_coursespassed]= name;
        m_coursespassed++;
    }
}


int main()
{
    student s;
    std::cout<< s.getGPA() << std::endl;
    return 0;
}