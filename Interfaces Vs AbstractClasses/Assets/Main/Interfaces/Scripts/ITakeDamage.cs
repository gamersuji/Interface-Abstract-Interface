namespace Interfaces
{
public interface ITakeDamage
{
	//int label; //interfaces can only have methods
	void TakeDamage(int damage); //everything is public automatically, doesn't have to determine it

	// bool SuperDamage() //Interface cannot contain defenitions as well
	// {
	// 	return false;
	// }

}
}
