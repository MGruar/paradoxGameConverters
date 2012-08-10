#ifndef CONFIGURATION_H_
#define CONFIGURATION_H_


#include <string>
using namespace std;



class Configuration // Singleton
{
public:
	Configuration();

	static string getCK2Path()
	{
		return getInstance()->CK2Path;
	}

	static string getEU3Path()
	{
		return getInstance()->EU3Path;
	}

	static string getHRETitle()
	{
		return getInstance()->HRETitle;
	}

	static int getID()
	{
		return getInstance()->id++;
	}

	static Configuration* getInstance()
	{
		if (instance == NULL)
			instance = new Configuration();
		return instance;
	}

private:
	static Configuration* instance;

	string	CK2Path;
	string	EU3Path;
	string	HRETitle;

	int		id;
};

#endif // CONFIGURATION_H_