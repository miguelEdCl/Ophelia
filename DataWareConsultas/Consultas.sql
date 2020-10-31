/*Primera Consulta*/
SELECT * FROM CatProducto;
/*Segunda Consulta*/
SELECT d.NProducto AS Producto, c.Pinventario AS Cantidad FROM CatProducto AS d
	INNER JOIN CatInventarioP AS c
		ON c.IdProducto = d.IdProducto WHERE c.PInventario = 5;
/*Tercera Consulta*/
SELECT c.PNombre AS 'Nombre Cliente', c.Edad AS 'Edad Cliente', f.FechaCompra AS 'Fecha Compra' FROM CatCliente AS c
	INNER JOIN CatFactura AS f
		ON f.IdCliente = c.IdCliente WHERE c.Edad <= 35 AND f.FechaCompra BETWEEN '20000201 00:00:00' AND '20000525 23:59:59';
/*Cuarta Consulta*/
SELECT DISTINCT p.NProducto AS 'Nombre Producto', SUM(TotalCompra) FROM CatFactura AS f
	INNER JOIN CatProducto AS p
		ON f.IdProducto = p.IdProducto
WHERE FechaCompra >= '2000-02-01'
GROUP BY p.NProducto;
/*Quinta Consulta*/
SELECT DISTINCT c.PNombre As 'Nombre Cliente', c.IdCliente AS ID, MAX(f.FechaCompra) AS UltimaFecha, 
DATEADD(dd,DATEDIFF(dd,MIN(f.FechaCompra),MAX(f.FechaCompra)), MAX(f.FechaCompra)) AS 'Posible Proxima Compra' 
FROM CatFactura AS F
	INNER JOIN CatCliente as c
		ON f.IdCliente = c.IdCliente
GROUP BY c.PNombre, c.IdCliente;