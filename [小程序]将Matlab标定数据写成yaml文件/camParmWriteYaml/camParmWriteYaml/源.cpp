#include <opencv2/opencv.hpp>
#include <iostream>

using namespace std;
using namespace cv;

int main(int argc, char** argv)
{
	///第一组数据
	//Mat leftCamMatrix = (Mat_<double>(3,3) << 1645.2,-1.2696,622.8323,
	//										  0,1645.7,457.3532,
	//										  0,0,1);
	//Mat rightCamMatrix = (Mat_<double>(3, 3) << 1636.7, -0.7845, 593.8285,
	//											0, 1636.6, 462.4908,
	//											0, 0, 1);
	////畸变系数   考虑k3是否去除
	//Mat leftDistCoeffs = (Mat_<double>(1, 5) << -0.3335, -0.4814, 0.0028, -0.0031, 2.8210);
	//Mat rightDistCoeffs = (Mat_<double>(1, 5) << -0.5374,4.6433,0.0014,-0.0003665,-39.7090);
	////立体矫正系数
	//Mat R = (Mat_<double>(3, 3) << 0.9999, 0.0051, -0.0131,
	//							   -0.0050, 1.0000, 0.0040,
	//							   0.0131, -0.0040, 0.9999);
	//Mat T = (Mat_<double>(3, 1) << -172.6820, 0.0480, -0.2051);		//注意，这里必须是3 * 1
	//Mat E = (Mat_<double>(3, 3) << 4.0978e-04, 0.2053, 0.0472,
	//							   -2.4651, 0.6954, 172.6631,
	//							   -0.9223, -172.6782, 0.6824);
	//Mat F = (Mat_<double>(3, 3) << 1.5218e-10, 7.6212e-08, -6.1052e-6,
	//								-9.1550e-07, 2.5754e-07, 0.1060,
	//								-1.3728e-04, -0.1051, 0.0238);
	/*FileStorage fs("CamParm.yaml", FileStorage::WRITE);
	fs << "leftCamMatrix" << leftCamMatrix;
	fs << "rightCamMatrix" << rightCamMatrix;
	fs << "leftDistCoeffs" << leftDistCoeffs;
	fs << "rightDistCoeffs" << rightDistCoeffs;
	fs << "R" << R;
	fs << "T" << T;
	fs << "E" << E;
	fs << "F" << F;
	fs.release();*/

	/////////第二组数据	
	Mat leftCamIntrinsic = (Mat_<double>(3, 3) <<
		814.8992, 0, 300.8411,
		0, 814.9672, 239.7614,
		0, 0, 1);
	Mat leftDistCoeffs = (Mat_<double>(1, 5) <<
		-0.3870, 0.2052, -0.0011, -0.0013, -0.1417);
	Mat rightCamIntrinsic = (Mat_<double>(3, 3) <<
		810.1948, 0, 300.1093,
		0, 810.5825, 239.4457,
		0, 0, 1);
	Mat rightDistCoeffs = (Mat_<double>(1, 5) <<
		-0.3798, 0.0337, -0.0011, 0.0012, 1.1944);
	Mat R = (Mat_<double>(3, 3) <<
		1, 0.0051, 8.0104e-04,
		-0.0051, 1, 4.5665e-04,
		-7.9868e-04, -4.6076e-04, 1);
	Mat T = (Mat_<double>(3, 1) <<
		-167.8875, -0.1353, 0.9616);
	Mat E = (Mat_<double>(3, 3) <<
		-0.0051, -0.9617, -0.1348,
		1.0961, 0.0717, 167.8866,
		-0.7279, -167.8859, 0.0722);
	Mat F = (Mat_<double>(3, 3) <<
		-7.6530e-09, -1.4565e-06, 1.8509e-04,
		1.6594e-06, 1.0857e-07, 0.2066,
		-0.0013, -0.2056, 0.2142);
	//计算出相关推导数据


	//写数据
	FileStorage fs("CamParm.yaml", FileStorage::WRITE);	
	fs << "leftCamIntrinsic" << leftCamIntrinsic;
	fs << "rightCamIntrinsic" << rightCamIntrinsic;
	fs << "leftDistCoeffs" << leftDistCoeffs;
	fs << "rightDistCoeffs" << rightDistCoeffs;
	fs << "R" << R;
	fs << "T" << T;
	fs << "E" << E;
	fs << "F" << F;
	fs.release();

	cout << "参数写入完毕" << endl;
	cin.get();
	return 0;
}


