USE [Siqi.CabsBooking]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (1, 'abdvs@gmail.com', GETDATE()-3, 1, 2, 1)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (2, 'abdvs@gmail.com', GETDATE()-5, 3, 5, 6)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (3, 'abdvs@gmail.com', GETDATE()-6, 4, 5, 2)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (4, 'abdvs@gmail.com', GETDATE()-7, 1, 3, 4)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (5, 'abdvs@gmail.com', GETDATE()-8, 1, 10, 3)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (6, 'abdvs@gmail.com', GETDATE()-1, 1, 4, 4)
INSERT Booking (Id, Email, BookingDate, FromPlaceId, ToPlaceId, CabTypeId) VALUES (7, 'abdvs@gmail.com', GETDATE()-6, 1, 7, 4)

UPDATE Booking SET ContactNo = '666-999-9000'
UPDATE Booking SET PickupDate = GETDATE()
UPDATE Booking SET PickupTime = GETDATE() + 1