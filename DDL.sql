CREATE TABLE Employees (
    EmployeeId     INTEGER       PRIMARY KEY
                                 NOT NULL,
    FullName       VARCHAR (250) NOT NULL,
    EmpCode        VARCHAR (10),
    Position       VARCHAR (100),
    OfficeLocation VARCHAR (100) 
);