public class WorldGenerator
{
    int sizeX = 42;
    int sizeY = 100;

    public WorldGenerator()
    {

    }

    public WorldGenerator(int sizeX, int sizeY)
    {
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        WorldGenerator();
    }
}