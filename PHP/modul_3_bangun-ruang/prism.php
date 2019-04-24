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
		<td>Alas</td>
		<td>:</td>
		<td><input type="text" name="Alas"/></td>
		</tr>
		<tr>
		<td>Tinggi</td>
		<td>:</td>
		<td><input type="text" name="Tinggi"/></td>
		</tr>
		<tr>
		<td>Tinggi Prisma</td>
		<td>:</td>
		<td><input type="text" name="Tinggi_"/></td>
		</tr>
		<tr>
		<td></td>
		<td colspan="2"><input type="submit" value="Hitung" name="Hitung"/></td>
		</tr>
	</table>
</form>
<?php
if(isset($_POST['Hitung'], $_POST['Alas'], $_POST['Tinggi'], $_POST['Tinggi_']))
{
	$a0 = $_POST['Alas'];
	$t0 = $_POST['Tinggi'];
	$t1 = $_POST['Tinggi_'];
	include 'calc.php';
	$calc = new bangunruang(); 
	$calc ->pthis($calc -> prisma($a0, $t0, $t1));
}else{
	echo "Masukan Nilainya!";
}
?>