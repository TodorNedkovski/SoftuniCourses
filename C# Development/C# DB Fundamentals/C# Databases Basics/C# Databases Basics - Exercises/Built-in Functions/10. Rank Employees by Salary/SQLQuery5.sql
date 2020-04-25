SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER(
Partition by Salary
order by EmployeeID
) RANK
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC