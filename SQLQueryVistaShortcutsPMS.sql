/****** Script for SelectTopNRows command from SSMS  ******/
USE [ShortcutsPOS]
GO

/****** Object:  View [dbo].[scvAppointment]    Script Date: 03/01/2017 16:07:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[scvShortcutsPMS] AS
SELECT  distinct(t.[SaleID])
      ,t.[Date]
      ,[ClientId]
      ,[Fax] as Hab
      ,[Time]
      ,SUM(h.Amount) - SUM (h.tax) as PrecioSinIva
      ,SUM (h.tax) as Iva
      ,SUM(h.[Amount]) as Precio
  FROM [ShortcutsPOS].[dbo].[transacs] t
  inner join [ShortcutsPOS].[dbo].[clients] c
  on t.ClientId = c.IdNumber
  inner join [ShortcutsPOS].[dbo].[historys] h
  on t.SaleID=h.SaleID
  group by t.SaleID,t.Date,t.ClientId,t.Amount,[Time],[FAX]
  
  GO
  