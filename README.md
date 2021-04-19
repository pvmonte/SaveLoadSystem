# SaveLoadSystem

Save/Load System to study SOLID Principles.

The system saves data as binary (unfortunately not some common unity data) and json (this one saves common unity data) with minor changes.

The classes that save and load use an interface with Generics to save any class is needed only creating an instance of save/load class and
passing the name of file that will be created or loaded.
