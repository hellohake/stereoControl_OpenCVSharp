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
	/*Mat leftCamIntrinsic = (Mat_<double>(3, 3) <<
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
		-0.0013, -0.2056, 0.2142);*/
	//计算出相关推导数据

	/////B=80mm数据
	/*Mat leftCamIntrinsic = (Mat_<double>(3, 3) <<
		814.939311130695, 0, 306.658425834701,
		0, 814.481345725390, 231.893812896700,
		0, 0, 1);
	Mat leftDistCoeffs = (Mat_<double>(1, 5) <<
		-0.378252729782653, 0.255180391000271, 
		-0.00133903765967010, -0.00214979916657107, -0.569524290186307);
	Mat rightCamIntrinsic = (Mat_<double>(3, 3) <<
		807.512549178254, 0, 301.119969736231,
		0, 807.644668027625, 233.849361134859,
		0, 0, 1);
	Mat rightDistCoeffs = (Mat_<double>(1, 5) <<
		-0.303681861826131, -1.53691848749168,
		-0.00143079005746779, 0.00120408886651931, 9.47427760645994);
	Mat R = (Mat_<double>(3, 3) <<
		0.999986384582198, 0.00172510558411321, -0.00492490212579967,
		-0.00170978513387024, 0.999993691884405, 0.00311333040228008,
		0.00493024188260992, -0.00310486748854545, 0.999983026112372);
	Mat T = (Mat_<double>(3, 1) <<
		-80.1617840695027, 0.0888245277139101, 0.218317009831070);
	Mat E = (Mat_<double>(3, 3) <<
		-0.000814071998127865, -0.218039092559536, 0.0895008654023790,
		-0.176474903418020, 0.249196844266713, 80.1614997680534,
		-0.227110859661630, -80.1611265288454, 0.248453790774461);
	Mat F = (Mat_<double>(3, 3) <<
		-1.23705289042567e-09, -3.31515580175211e-07, 0.000188091027165757,
		-2.68125027932919e-07, 3.78827123232123e-07, 0.0992478004837601,
		-0.000215611015867846, -0.0984086059565189, -0.108805237037753);*/

	//基线距离80mm时的数据，修正后数据
	Mat leftCamIntrinsic = (Mat_<double>(3, 3) <<
		815.196723462393, 0.208630486244067, 306.540293019016,
		0, 814.733567124159, 230.478090999635,
		0, 0, 1);
	Mat leftDistCoeffs = (Mat_<double>(5, 1) <<
		-0.367918203634284, 0.116920596569155,
		-0.00141742722850052, -0.00233916461467300, 0);
	Mat rightCamIntrinsic = (Mat_<double>(3, 3) <<
		808.275247050855, -0.126962241753312, 301.621207820493,
		0, 808.426367807631, 232.856521916083,
		0, 0, 1);
	Mat rightDistCoeffs = (Mat_<double>(5, 1) <<
		-0.357941998659271, -0.158040227267885,
		-0.00136576046061445, 0.00113617734741430, 0);
	Mat R = (Mat_<double>(3, 3) <<
		0.999990348589389, -0.00142312039744450, 0.00415661598023396,
		0.00143808746584384, 0.999992485867856, -0.00360001559264393,
		-0.00415146149125122, 0.00360595842475672, 0.999984881101372);

	Mat T = (Mat_<double>(3, 1) <<
		-80.1579543492859, 0.0900288014118860, 0.158224536460850);
	Mat E = (Mat_<double>(3, 3) <<
		-0.000601291824838248, -0.157898707425852, 0.0905970510739618,
		-0.174549651327654, 0.288821078231859, 80.1574001279366,
		-0.205302081944348, -80.1572239100009, 0.288195670377239);
	Mat F = (Mat_<double>(3, 3) <<
		-9.12564551849288e-10, -2.39774648457751e-07, 0.000167629421609507,
		-2.64859969726134e-07, 4.38533405477296e-07, 0.0991325176227875,
		-0.000189893985229133, -0.0984143147824982, -0.0933414905498289);

	Size imgSize(640, 480);
	Mat R1, R2,P1,P2,Q;
	Rect PixROI1, PixROI2;
	//计算相关参数 , 还是在用到时再计算比较好
	stereoRectify(leftCamIntrinsic, leftDistCoeffs, rightCamIntrinsic, rightDistCoeffs, imgSize,
					R, T, R1, R2, P1, P2, Q, CALIB_ZERO_DISPARITY, 0, imgSize, &PixROI1, &PixROI2);
	//计算校正映射
	Mat leftMap1, leftMap2;
	Mat rightMap1, rightMap2;
	initUndistortRectifyMap(leftCamIntrinsic, leftDistCoeffs, R1, P1, imgSize, CV_16SC2, leftMap1, leftMap2);
	initUndistortRectifyMap(rightCamIntrinsic, rightDistCoeffs, R2, P2, imgSize, CV_16SC2, rightMap1, rightMap2);

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
	fs << "R1" << R1;
	fs << "R2" << R2;
	fs << "P1" << P1;
	fs << "P2" << P2;
	fs << "Q" << Q;
	//fs << "PixROI1" << PixROI1;
	//fs << "PixROI2" << PixROI2;
	//fs << "leftMap1" << leftMap1;
	//fs << "leftMap2" << leftMap2;
	//fs << "rightMap1" << rightMap1;
	//fs << "rightMap2" << rightMap2;
	fs.release();

	cout << "参数写入完毕" << endl;
	cin.get();
	return 0;
}


