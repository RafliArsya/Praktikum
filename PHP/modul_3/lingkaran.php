<?php
	include 'main.php';
?>
<form action="main.php">
	<table>
		<tr>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
		<td><input type="submit" value="back" name="Menu"/></td>
		</tr>
	</table>
</form>
<form method="post">
	<table>
		<tr>
		<td>Jari-jari</td>
		<td>:</td>
		<td><input type="text" name="Jari"/></td>
		</tr>
		<tr>
		<td></td>
		<td colspan="2"><input type="submit" value="hasil" name="hasil"/></td>
		</tr>
	</table>
</form>
<?php
if(isset($_POST['hasil'], $_POST['Jari']))
{
	$jari = $_POST['Jari'];
	include 'calc.php';
	$calc = new bangunruang(); 
	$calc -> lingkaran($jari);
}else{
	echo "Masukan Nilainya!";
}
?>