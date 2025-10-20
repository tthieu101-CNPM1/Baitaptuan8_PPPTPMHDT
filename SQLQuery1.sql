CREATE TABLE [dbo].[NhaXuatBan]
(
    [NXB] char(10),
    [TenNXB] nvarchar(100), 
    [DiaChi] nvarchar(500), 
    primary key (NXB) 
)

	CREATE TABLE [dbo].[Sach]
(
    [MaSach] char(10),
    [TenSach] nvarchar(300),
    [NXB] char(10),
    [TenTG] nvarchar(100),
    [NamXB] datetime,
    [GhiChu] nvarchar(500),
    primary key (MaSach)
)

alter table Sach
add foreign key (NXB) references NhaXuatBan (NXB)

-- Thêm dữ liệu cho bảng NhaXuatBan
insert into NhaXuatBan
values ('001', N'Học viện X-men', N'Quang Trung, HÀ NỘI')
insert into NhaXuatBan
values ('002', N'Khoa học xã hội', N'Trần Phú, HÀ Nội')
insert into NhaXuatBan
values ('003', N'Viện văn hóa thể thao', N'Hai Bà Trưng, HÀ Nội')

-- Thêm dữ liệu cho bảng Sach
insert into Sach
values ('1', N'Lập trình C#', '001', N'Nguyễn Lưu', CONVERT(datetime, '2022'), 'Khg')
insert into Sach
values ('2', N'Lập trình ASP.NET core', '002', N'Trọng Khải', CONVERT(datetime, '2019'), 'Khg')
insert into Sach
values ('3', N'Lập trình Scratch', '002', N'Bá Trọng', CONVERT(datetime, '2022'), 'Khg')



create proc HienThiNXB
as
begin
    select * from NhaXuatBan
end



create proc HienThiChiTietNXB
@maNXB char(10)
as
begin
    select *
    from NhaXuatBan
    where NXB=@maNXB
end

	create proc ThemDuLieu
		@maNXB char(10),
		@tenNXB nvarchar(100),
		@diaChi nvarchar(500)
	as
	begin
		insert into NhaXuatBan
		values (@maNXB, @tenNXB, @diaChi)
	end

create proc CapNhatThongTin
    @maNXB char(10),       -- [cite: 339]
    @tenNXB nvarchar(100), -- [cite: 341]
    @diaChi nvarchar(500)  -- [cite: 343]
as
begin
    update NhaXuatBan      -- [cite: 349]
    set
        -- NXB = @maNXB,   -- (Dòng này không cần thiết vì bạn không cập nhật khóa chính)
        TenNXB = @tenNXB,  -- [cite: 355]
        DiaChi = @diaChi   -- [cite: 357]
    where NXB = @maNXB     -- [cite: 359]
end



create proc XoaNXB
    @maNXB char(10) 
as
begin
    
    delete from NhaXuatBan where NXB = @maNXB
end




-- Kiểm tra xem đã tồn tại chưa, nếu có thì xóa đi
IF OBJECT_ID('XoaNXB', 'P') IS NOT NULL
    DROP PROCEDURE XoaNXB;
GO

-- Tạo lại procedure
create proc XoaNXB
    @maNXB char(10) -- [cite: 380]
as
begin
    delete from NhaXuatBan where NXB = @maNXB -- [cite: 386]
end
GO

PRINT 'Đã tạo thành công Stored Procedure XoaNXB.';