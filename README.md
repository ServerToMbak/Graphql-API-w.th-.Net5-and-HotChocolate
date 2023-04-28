# Graphql-API-with-.Net5-and-HotChocolate


GraphQl  
GraphQL provides a more efficient, powerful and flexible alternative to traditional RESTful API services. It allows clients to request specific data they need, 
and the server only returns that data. This minimizes the amount of data transferred between the server and the client, resulting in faster and more efficient
communication.

Requests:http://localhost:5000/graphql/
When making test of the queries the request path alsays will be same and in insomnia you should choose body as graphQL and the request type is always will be 
choosen POST

Get Platform:

query{
	platform{
		id
		name
	}
}

Get Commands:

query{
	command
	{
		howTo
		commandLine
		platform{
			name
		}
	}
}

Get Platforms and Commands:

query{
	command
	{
		howTo
		commandLine
		platform{
			name
		}
	}
}

Get Platform with Ascending sorting by name:

query{
	platform(order: {name: ASC})
	{
		name
	}
}
Filter Query:

query{
	command(where:{platformId:{eq:1}})
	{
		id
		platform{
			name
			id
		}
		commandLine
		howTo
	}
}

Add Platform:

mutation{
	addPlatform(input: {
		name:"RedHat"
	})
	{
		platform
		{
			id
			name
		}
	}
}

Add Command:

mutation{
	addCommand(input: {
		howTo: "perform directory listening"
		commandLine :"ls"
		platformId: 5
	})
	{
		command{
			id
			howTo
			commandLine
			platform{
				name
			}	
		}
	}
}


Thats How it looks with insomnia:


![image](https://user-images.githubusercontent.com/69975139/235103078-d23ff489-cc29-4a8c-8ab6-b875b3c99298.png)

