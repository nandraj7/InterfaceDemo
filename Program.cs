
using InterfaceDemo;

Student student = new Student();

student.Test();

Person1 person1;
person1 = student;
person1.Test();

Employee employee = new Employee(); 
//employee.Test();

InterfaceDemo1 interfaceDemo1;
interfaceDemo1 = employee;
interfaceDemo1.Test();

InterfaceDemo2 interfaceDemo2;
interfaceDemo2 = employee;
interfaceDemo2.Test();



Doctor doctor = new Doctor();
IDoctor iDoctor;
iDoctor = doctor;
iDoctor.GetData();
iDoctor.PutData();
