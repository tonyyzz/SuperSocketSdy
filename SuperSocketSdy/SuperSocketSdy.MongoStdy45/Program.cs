using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSocketSdy.MongoStdy45
{
	class Program
	{
		static void Main(string[] args)
		{


			//// 连接到 mongodb 服务
			//MongoClient mongoClient = new MongoClient("mongodb://192.168.0.120:27017");
			//// 连接到数据库
			//var mongoDatabase = mongoClient.GetDatabase("mycol3");
			//var collection = mongoDatabase.GetCollection<Auth>("test3");
			//collection.InsertOne(new Auth { });

			MgHelper<Auth> mg = new MgHelper<Auth>();
			//插入
			//mg.Insert(new Auth() { });
			//mg.Insert(new Auth() { });
			//修改
			//mg.Modify("5a8e29d58c66621a204a1992", "State", "n");
			//查找一个
			//var auth = mg.QueryOne("5a8e29d58c66621a204a1992");

			//查找所有
			var list = mg.QueryAll();

			//删除
			//mg.Delete("5a8e29d58c66621a204a1992");

			//更新
			//var auth = mg.QueryOne("5a8e2efe8c666235104b5898");
			//mg.Update(auth);

			//删除表
			//mg.Drop();

			Console.WriteLine(JsonConvert.SerializeObject(list));
			Console.ReadKey();
		}
	}
	public class Auth : BaseEntity
	{

	}
}
