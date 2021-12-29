Create database HR 
go 
use HR
create table Employee(
idEmployee nvarchar(255),
Name nvarchar(255),
DateBirth date,
Gender bit,
PlaceBirth nvarchar(255),
idDepartment nvarchar(10)
)

Create table Deparment(
idDepartment nvarchar(10),
Name nvarchar(255),
)
insert into Deparment values('NS',N'Nhân sự');
insert into Deparment values('KT',N'Kế toán');
insert into Deparment values('KD',N'Kinh doanh');


select * from Deparment	

insert into Employee values(N'C53418',N'Trần Tiến','2000-10-11',1,N'Hà Nội','KT');
insert into Employee values(N'X53416',N'Nguyễn Cường','1999-07-21',0,N'Đắk Lắk','KD');
insert into Employee values(N'M53417',N'Nguyễn Hào','2001-12-25',1,N'TP.Hồ Chí Minh','NS');

select * from Employee

Create Procedure getAllEmployees
As 
Begin 
	Select * 
	From Employee
End 
Exec getAllEmployees

Create Procedure addEmployee(@idEmployee nvarchar(255),@Name nvarchar(255),@DateBirth date,@Gender bit,@PlaceBirth nvarchar(255),@idDepartment nvarchar(10))
as 
Begin 
	insert into Employee values(@idEmployee,@Name,@DateBirth,@Gender,@PlaceBirth,@idDepartment);
End
drop proc addEmployee


Create Procedure deleteEmployee (@idEmployee nvarchar(255))
As
Begin
	delete from Employee where idEmployee = @idEmployee;
End
drop proc deleteEmployee

Create Procedure editEmployee(@idEmployee nvarchar(255),@Name nvarchar(255),@DateBirth date,@Gender bit,@PlaceBirth nvarchar(255),@idDepartment nvarchar(10))
as
Begin
	update Employee set Name=@Name,
						DateBirth=@DateBirth,
						Gender=@Gender,
						PlaceBirth=@PlaceBirth,
						idDepartment=@idDepartment
	where idEmployee=@idEmployee;
end



Create Procedure getAllDepartment
As 
Begin 
	Select * 
	From Deparment
End 
delete from Employee
exec getAllDepartment
Create Procedure readDepart(@idDepartment nvarchar(10))
as
begin
select*
from Deparment
where idDepartment=@idDepartment
end
drop proc readDepart