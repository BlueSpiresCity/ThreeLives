using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	TextManager TextControl;
	
	void Awake(){
		//Create a New World!
		new World();
		//AND DECLARE ITS MASTER!
		World.Instance.Master = this;
	}
	
	void Start () {
		TextControl = World.Instance.TextControl;
		TextControl.CreateText(
			"Lorem ipsum dolor sit amet, consectetur adipiscing elit. <Item>Crowbar In lobortis ultrices pulvinar. " +
			"Nulla mauris diam, rhoncus eu dui a, <Item>Crowbar ullamcorper magna. Suspendisse adipiscing, " +
			"ligula sed suscipit fringilla, arcu sem eleifend dolor, vel tristique lacus sapien et quam. Curabitur in " +
			"ultrices orci. Integer <Item>Crowbar eu odio in tempus. In nec semper ante. Suspendisse volutpat rutrum " +
			"mollis. Fusce facilisis eget nunc sed ultrices. Mauris ut iaculis odio. Donec sit amet orci et lorem varius" +
			 "bibendum a eu orci. Nunc placerat dui eu mauris viverra volutpat. Sed sagittis sed nulla at vulputate. " +
			 "Mauris eu quam est. Quisque ullamcorper nibh id mollis sagittis. Vestibulum id eros mollis, volutpat" +
			  "lacus at, pellentesque tellus. Cras nunc leo, luctus eget consectetur id, pulvinar non justo. Proin tempor" +
			   "tortor ut dui varius lobortis. Maecenas scelerisque tellus sed lorem semper, a sodales lectus vulputate. " +
			   "Donec ligula diam, bibendum eu congue quis, dapibus quis nisi. In rutrum nisl sed odio faucibus, a " +
			   "accumsan arcu egestas. Mauris lacinia magna at malesuada. Ut cursus nunc et nibh pharetra " +
			   "pharetra. Nam lectus risus, hendrerit lacinia feugiat non, fringilla et tellus. Quisque tincidunt, nisi et euismod " +
			   "hendrerit, est enim semper sapien, molestie bibendum mauris justo ac leo. Quisque in rhoncus risus, " +
			   "non hendrerit eros. Praesent varius diam dolor, facilisis interdum neque placerat nec. Fusce bibendum, " +
			   "dui rhoncus ullamcorper imperdiet, dolor neque tristique nisl, nec porttitor odio magna et nulla. In varius " +
			   "consectetur ante, et tempor tellus commodo quis. Ut pretium pharetra lorem ac molestie. Sed sed diam " +
			   "tincidunt, volutpat sem ut, semper augue. Maecenas at nulla eu massa fermentum molestie id eu tellus. " +
			   "Donec in elit quis nibh adipiscing iaculis eget ut nisi. Pellentesque est velit, pretium ac lobortis a, suscipit " +
			   "eget ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse in facilisis nunc, ac " +
			   "condimentum diam. Ut vitae est nec erat pharetra lacinia. Nam rutrum ligula eu tortor interdum, ut" +
			    "bibendum enim consequat. Vivamus suscipit mattis orci in scelerisque. Phasellus vel iaculis nunc. " +
			    "Mauris malesuada posuere rhoncus. Nam venenatis libero dignissim, varius dolor nec, volutpat justo. " +
			    "Aenean sollicitudin, velit vel aliquet gravida, risus velit imperdiet purus, vitae egestas nulla dui sed felis." +
			     "Nam convallis dui justo, at tincidunt metus eleifend id. Aenean ac mi ac nisi ultrices pharetra ut sed ante.");
	}

	void Update () {
		
	}
}
