---Role
Insert into [dbo].[Role](RoleName,RoleDescription) values ('Admin','System management');
Insert into [dbo].[Role](RoleName,RoleDescription) values ('Monitor','System Admin');
Insert into [dbo].[Role](RoleName,RoleDescription) values ('User','Using Client');
--- Employeee
Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN001','tc&4512','Dang','Tuan huy','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',2);
Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN002','tc&4512','Dang','Quang','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',2);

Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN003','tc&4512','Dang','Hung','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',2);

Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN004','tc&4512','Dang','Hao','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',2);
Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN005','tc&4512','Dang','Minh','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',1);
Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN006','tc&4512','Phong','Ly','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',1);

Insert into [dbo].[Employee]
([EmployeeCode],[EmployeePass],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],
[Address],[PostalCode],[HomePhone],[Extension],[EmployeeImg],[Notes],[ReportsTo],[RoleId]) 
values('TN007','tc&4512','Dang','Tuan huy','Employee','University','12/12/1987','8/17/2018','Ben Tre City','9990012','0963456789','','','News Employee','',2);

-- Brannch
Insert Into [dbo].[Branch] ([BranchName],[BranchDetails],[EmployeeCode]) values ('American','American','TN007');
Insert Into [dbo].[Branch] ([BranchName],[BranchDetails],[EmployeeCode]) values ('Can Tho','Cai Rang','TN005');
Insert Into [dbo].[Branch] ([BranchName],[BranchDetails],[EmployeeCode]) values ('Hau Giang','Phung Hiep','TN005');
Insert Into [dbo].[Branch] ([BranchName],[BranchDetails],[EmployeeCode]) values ('Ben Tre','Chau Thanh','TN004');
Insert Into [dbo].[Branch] ([BranchName],[BranchDetails],[EmployeeCode]) values ('An Giang','Cho Moi','TN003');
-- About
Insert into [dbo].[About] ([AboutUs],[AboutDetails],[EmployeeCode]) values ('Company - BenTre','Building a website is, in many ways, an exercise of willpower. It’s tempting to get distracted by the bells and whistles of the design process, and forget all about creating compelling content. ','TN007');
Insert into [dbo].[About] ([AboutUs],[AboutDetails],[EmployeeCode]) values ('Company - Cai Rang','Building a website is, in many ways, an exercise of willpower. It’s tempting to get distracted by the bells and whistles of the design process, and forget all about creating compelling content. ','TN007');
Insert into [dbo].[About] ([AboutUs],[AboutDetails],[EmployeeCode]) values ('Company - Hau Giang','Building a website is, in many ways, an exercise of willpower. It’s tempting to get distracted by the bells and whistles of the design process, and forget all about creating compelling content. ','TN006');
-- News
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('News Dayly','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
Insert News ([NewTitles],[NewsDetails],[NewsBy],[NewsDate],[EmployeeCode]) values ('Newspaper','Brent is heading for a 2 percent decline this week, a third consecutive weekly drop. WTI is on track for a seventh week of losses, with a fall of more than 3 percent.','Nguyen Hong Minh','12/12/2018','TN004');
--- Custommer
Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User1',
 'ff%eawjdadsd_nfdka',
 'Dang Tuan Huy',
 'Cusc',
 'Ben Tre',
 'North',
 '00987',
 '0963505927',
 '04.39276181.','3');

 Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User2',
 'ff%eawjdadsd_nfdka',
 'Trai Dai Loi',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
  Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User3',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User4',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User5',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User6',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User7',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User8',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User9',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
   Insert [dbo].[Customer] (
[CustomerCode],
[CustomerPass],
[CustomerFullName],
[ContactCompany],
[CustomerAddress],
[CustomerRegion],
[CustomerPostalCode],
[CustomerPhone],
[CustomerFax],
[RoleId]) values
 ('User10',
 'ff%eawjdadsd_nfdka',
 'Nguoi Khan Trang',
 'Cusc',
 'Can Thi',
 'North',
 '00987',
 '0963505933',
 '04.39276181.','3');
 --- Promotion
 Insert into Promotion ([PromotionName],[PromotionDetails],[PromotionDiscount],[PromotionStatus],[PromotionOpen],[PromotionClose]) 
 values ('Full moon','Discount 20%','20',1,'8/17/2018','8/30/2018');
  Insert into Promotion ([PromotionName],[PromotionDetails],[PromotionDiscount],[PromotionStatus],[PromotionOpen],[PromotionClose]) 
 values ('Quoc Khanh 2-9','Discount 45%','20',1,'8/17/2018','8/30/2018');
  Insert into Promotion ([PromotionName],[PromotionDetails],[PromotionDiscount],[PromotionStatus],[PromotionOpen],[PromotionClose]) 
 values ('Thuong Binh Liet Si','Discount 5%','20',1,'8/17/2018','8/30/2018');
  Insert into Promotion ([PromotionName],[PromotionDetails],[PromotionDiscount],[PromotionStatus],[PromotionOpen],[PromotionClose]) 
 values ('20-11','Discount 40%','20',1,'8/17/2018','8/30/2018');
 --- Products
 Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product1','Product1',1,'8/17/2018',87,'300000','450000',1,1);
  Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product2','Product2',1,'8/17/2018',87,'300000','450000',1,1);
  Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product2','Product2',1,'8/17/2018',89,'300000','450000',1,1);
   Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product3','Product2',0,'8/17/2018',89,'300000','450000',1,1);
   Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product4','Product2',1,'8/17/2018',89,'300000','450000',1,1);
   Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product5','Product2',1,'8/17/2018',89,'300000','450000',1,1);
   Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product6','Product2',1,'8/17/2018',89,'300000','450000',1,2);
   Insert into Products ([ProductName],[ProductDetails],[ProductStatus],[ProductUpdate],[ProductQty],[ProductSold],[ProductsOldPrice],[SupplierId],[CategoryId]) 
 values ('Product7','Product2',1,'8/17/2018',89,'300000','450000',1,1);
 --Product - Promotion
 Insert Product_Promotion([PromotionId],[ProductId],[Gift]) values(1,1,'Gau Bong');
  Insert Product_Promotion([PromotionId],[ProductId],[Gift]) values(1,2,'Gau Bong');
   Insert Product_Promotion([PromotionId],[ProductId],[Gift]) values(1,3,'Gau Bong');
    Insert Product_Promotion([PromotionId],[ProductId],[Gift]) values(2,1,'Gau Bong');
	 Insert Product_Promotion([PromotionId],[ProductId],[Gift]) values(2,2,'Gau Bong');
-- Insert Order
Insert into [dbo].[Order]([CustomerCode],[OrderDate],[RequiredDate],[ShippedDate],[Freight],[OrderAddress]) 
values('User1','12-12-1996','8-17-2018','12-12-2018','8000','Binh Dinh');
Insert into [dbo].[Order]([CustomerCode],[OrderDate],[RequiredDate],[ShippedDate],[Freight],[OrderAddress]) 
values('User2','12-12-1996','8-17-2018','12-12-2018','8000','Binh Dinh');
Insert into [dbo].[Order]([CustomerCode],[OrderDate],[RequiredDate],[ShippedDate],[Freight],[OrderAddress]) 
values('User3','12-12-1996','8-17-2018','12-12-2018','8000','Binh Dinh');
Insert into [dbo].[Order]([CustomerCode],[OrderDate],[RequiredDate],[ShippedDate],[Freight],[OrderAddress]) 
values('User4','12-12-1996','8-17-2018','12-12-2018','8000','Binh Dinh');
Insert into [dbo].[Order]([CustomerCode],[OrderDate],[RequiredDate],[ShippedDate],[Freight],[OrderAddress]) 
values('User5','12-12-1996','8-17-2018','12-12-2018','8000','Binh Dinh');
-- Insert Order-Details
Insert [dbo].[OrderDetails]([OrderId],[ProductId],[SoldPrice],[Quantity],[Payment]) values(1,1,45000,45,1);
Insert [dbo].[OrderDetails]([OrderId],[ProductId],[SoldPrice],[Quantity],[Payment]) values(2,1,45000,45,1);
Insert [dbo].[OrderDetails]([OrderId],[ProductId],[SoldPrice],[Quantity],[Payment]) values(3,1,45000,45,1);
Insert [dbo].[OrderDetails]([OrderId],[ProductId],[SoldPrice],[Quantity],[Payment]) values(4,1,45000,45,1);
Insert [dbo].[OrderDetails]([OrderId],[ProductId],[SoldPrice],[Quantity],[Payment]) values(5,1,45000,45,1);
-- Insert Delivery
Insert into [dbo].[Delivery]([DeliveryTitle],[DeliveryDetails],[DeliveryQuestion],[EmployeeCode]) 
values ('LOREM IPSUM IS SIMPLY DUMMY TEXT','Lorem ipsum dolor sit amet','What is Lorem Ipsum?','TN002');

Insert into [dbo].[Delivery]([DeliveryTitle],[DeliveryDetails],[DeliveryQuestion],[EmployeeCode]) 
values ('LOREM IPSUM IS SIMPLY DUMMY TEXT','Lorem ipsum dolor sit amet','What is Lorem Ipsum?','TN006');
-- Insert Contact

Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Nguyen Thi Loi','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');
Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Nguyen Thi Thuy Chung','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');
Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Huynh Quang Trung','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');

Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Nguyen Thi Loi','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');
Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Nguyen Thi Thuy Chung','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');
Insert into [dbo].[Contact]([CompanyName],[ContactName],[Address],[Region],[PostalCode],[Phone],[Fax])
values('Fbt','Huynh Quang Trung','Can Tho','East','9235683','+(84) 9634502831','+84 (8) 3823 3318');