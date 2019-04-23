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
		<td>P</td>
		<td>:</td>
		<td><input type="text" name="Panjang"/></td>
		</tr>
		<tr>
		<td>L</td>
		<td>:</td>
		<td><input type="text" name="Lebar"/></td>
		</tr>
		<tr>
		<td></td>
		<td colspan="2"><input type="submit" value="Hitung" name="Hitung"/></td>
		</tr>
	</table>
</form>
<?php
if(isset($_POST['Hitung'], $_POST['Lebar'], $_POST['Panjang']))
{
	$panjang = $_POST['Panjang'];
	$lebar = $_POST['Lebar'];
	include 'calc.php';
	$calc = new bangunruang(); 
	$calc -> persegi($panjang, $lebar);
}else{
	echo "Masukan Nilainya!";
}
?>