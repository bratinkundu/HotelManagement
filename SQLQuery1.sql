CREATE TABLE Hotel
(
	HotelId int IDENTITY(1,1) PRIMARY KEY,
	HotelName varchar(50) NOT NULL,
	HotelAddress varchar(100) NOT NULL,
	HotelCity varchar(30) NOT NULL,
	HotelPinCode int NOT NULL,
	ContactNumber BIGINT NOT NULL,
	ContactPerson varchar(20) NOT NULL,
	HotelWebsite varchar(20) NOT NULL,
	Facebook varchar(20),
	Twitter varchar(20),
	IsActive bit NOT NULL,
	CreatedDate datetime NOT NULL,
	CreatedBy varchar(30) NOT NULL,
	UpdatedDate datetime NOT NULL,
	UpdatedBy varchar(30) NOT NULL
)



CREATE TABLE Room
(
	RoomId int IDENTITY(1,1) PRIMARY KEY,
	HotelId int FOREIGN KEY (HotelId) REFERENCES Hotel(HotelId),
	RoomName char(10) NOT NULL,
	RoomCategory varchar(20) NOT NULL,
	RoomPrice decimal(10,2) NOT NULL,
	IsActive bit NOT NULL,
	CreatedDate datetime NOT NULL,
	CreatedBy varchar(30) NOT NULL,
	UpdatedDate datetime NOT NULL,
	UpdatedBy varchar(30) NOT NULL
)



CREATE TABLE Booking
(
	BookingId int IDENTITY(1,1) PRIMARY KEY,
	RoomId int FOREIGN KEY (RoomId) REFERENCES Room(RoomId),
	BookingDate datetime NOT NULL,
	BookingStatus char(10) DEFAULT 'Optional'
)