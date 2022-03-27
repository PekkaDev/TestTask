create table Product
(
    Id int primary key,
    ProductName nvarchar(50)
);

create table Category
(
    Id int primary key,
    CategoryName nvarchar(50)
);

create table ProductCategory
(
    ProductId int references Product(Id),
    CategoryId int references Category(Id),
    primary key (ProductId,CategoryId)
);

select p.ProductName, c.CategoryName
from Product p
left join ProductCategory pc
on p.Id=pc.ProductId
left join Category c
on c.Id=pc.CategoryId