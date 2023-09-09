﻿
namespace ASCOM.Astrometry
{
    static class Sat404Data
    {
        // /*
        // First date in file = 625296.50
        // Number of records = 16731.0
        // Days per record = 131.0
        // Julian Years      Lon    Lat    Rad
        // -3000.0 to  -2499.7:   0.78   0.26   0.55
        // -2499.7 to  -1999.7:   0.66   0.19   0.57
        // -1999.7 to  -1499.7:   0.62   0.19   0.53
        // -1499.7 to   -999.8:   0.79   0.17   0.61
        // -999.8 to   -499.8:   0.78   0.15   0.42
        // -499.8 to      0.2:   0.75   0.19   0.52
        // 0.2 to    500.2:   0.62   0.18   0.41
        // 500.2 to   1000.1:   0.56   0.13   0.54
        // 1000.1 to   1500.1:   0.53   0.15   0.41
        // 1500.1 to   2000.1:   0.51   0.15   0.49
        // 2000.1 to   2500.0:   0.52   0.13   0.41
        // 2500.0 to   3000.0:   0.63   0.22   0.53
        // 3000.0 to   3000.4:  0.047  0.073  0.086
        // */


        internal static double[] tabl = new double[] { 1788381.2624d, 2460423.68044d, 1370113.15868d, 415406.99187d, 72040.39885d, 12669.58806d, 439960754.85333d, 180256.80433d, 18.71177d, -40.37092d, 66531.01889d, -195702.70142d, 57188.02694d, -179110.60982d, -19803.0652d, -58084.15705d, -9055.13344d, -31146.10779d, 11245.43286d, -3247.59575d, 459.4867d, 2912.82402d, -4.06749d, -13.53763d, -30.55598d, -4.51172d, 1.48832d, 0.37139d, 597.35433d, 1193.44545d, -297.50957d, 976.38608d, -263.26842d, 34.84354d, -6.77785d, -29.92106d, -0.16325d, -0.18346d, -0.15364d, -0.08227d, 0.2018d, 0.02244d, 0.04672d, -0.29867d, -0.04143d, -0.0076d, -0.17046d, -0.00778d, 0.042d, 0.23937d, -0.00098d, -0.05236d, -0.02749d, -0.01813d, 0.00637d, 0.01256d, -0.04506d, 0.04448d, -0.00105d, 0.06224d, 0.01157d, 0.17057d, -0.03214d, 0.18178d, -0.22059d, -0.01472d, -0.24213d, 0.04309d, 0.03436d, 0.44873d, 0.0135d, -0.01931d, -0.80618d, -0.56864d, 0.29223d, -0.03101d, 0.04171d, 0.02264d, -0.01264d, -0.01645d, 0.01774d, 0.06374d, -0.01925d, -0.03552d, 0.10473d, -0.04119d, 0.08045d, 0.04635d, -3.01112d, -9.26158d, 8.13745d, 1.88838d, -0.15184d, 0.16898d, -0.22091d, 0.2907d, -0.03259d, 0.06938d, -0.08499d, -0.21688d, 0.01848d, -0.05594d, 0.501d, -0.00027d, 0.133d, 0.12055d, 0.03039d, 0.03854d, -1.55287d, 2.55618d, -0.45497d, -0.29895d, -0.93268d, 0.83518d, -0.32785d, 7.03878d, -1.66649d, 2.75564d, -0.29459d, 0.0105d, 0.08293d, -0.03161d, -0.1275d, -0.04359d, 0.04217d, 0.0748d, -114.43467d, 49.47867d, -66.5234d, -26.27841d, 15.4819d, -13.06589d, 3.28365d, 5.02286d, -0.17155d, -0.07404d, 0.00924d, -0.07407d, -0.02922d, 0.06184d, 108.04882d, 86.09791d, -155.12793d, 208.10044d, -311.7281d, -268.92703d, 74.57561d, -420.03057d, -0.07893d, 0.09246d, -0.66033d, -0.39026d, -0.13816d, -0.0849d, -36.79241d, -78.88254d, 71.88167d, -68.05297d, 51.71616d, 65.7797d, -43.59328d, 23.51076d, -0.02029d, -0.32943d, -8.82754d, 1.48646d, -3.12794d, 2.12866d, -0.06926d, 0.44979d, 0.00621d, -0.5172d, -3.82964d, -1.48596d, -0.11277d, -3.21677d, 0.81705d, -0.19487d, -0.06195d, 0.10005d, -0.02208d, 0.00108d, 0.00455d, -0.03825d, 0.01217d, -0.00599d, -0.17479d, -0.4729d, 0.85469d, 1.12548d, -0.80648d, -0.44134d, -0.01559d, -0.07061d, 0.01268d, -0.01773d, 0.01308d, -0.03461d, -0.71114d, 1.9768d, -0.78306d, -0.23052d, 0.94475d, -0.10743d, 0.18252d, -8.03174d, 0.00734d, 0.04779d, 0.12334d, -0.03513d, 0.01341d, 0.02461d, 0.02047d, -0.03454d, 0.02169d, -0.01921d, -1.12789d, 0.09304d, 0.14585d, 0.36365d, 0.03702d, 0.10661d, -0.00464d, -1.72706d, -0.00769d, -0.04635d, -0.01157d, 0.00099d, 10.92646d, 1.96174d, 2.91142d, 4.74585d, -0.29832d, 0.75543d, 0.05411d, 1.0585d, 0.38846d, -0.16265d, 1.52209d, 0.12185d, 0.1865d, 0.35535d, -278.33587d, -82.58648d, -160.00093d, -225.55776d, 35.17458d, -77.56672d, 10.61975d, 3.33907d, 0.0609d, 2.17429d, -4.32981d, -5.84246d, 11.43116d, 20.61395d, -0.65772d, 1.28796d, 1224.46687d, -3113.15508d, 3798.33409d, -137.28735d, -256.89302d, 2227.35649d, -779.78215d, -260.37372d, 11.73617d, -13.2505d, -0.75248d, -2.87527d, -8.38102d, 17.21321d, -61784.69616d, 39475.02257d, -54086.68308d, 54550.8549d, -16403.69351d, 29602.70098d, 14672.06363d, 16234.17489d, 15702.37109d, -22086.303d, -22889.89844d, -1245.88352d, 1.48864d, 19.75d, 0.78646d, 3.29343d, -1058.13125d, 4095.02368d, -2793.78506d, 1381.93282d, -409.19381d, -772.5427d, 161.67509d, -34.1591d, -514.27437d, 27.34222d, -311.04046d, 48.0103d, -43.36486d, 16.19535d, -0.73816d, -0.81422d, 287.32231d, -110.44135d, 200.4361d, 37.9817d, 17.73719d, 34.40023d, -2.46337d, 1.48125d, 0.09042d, -0.11788d, 0.37284d, 0.51725d, 0.00597d, 0.1459d, -0.01536d, 0.0098d, 0.00721d, 0.02023d, 0.00027d, 0.02451d, -0.72448d, -0.71371d, 0.29322d, 0.18359d, 0.72719d, -0.37154d, 0.14854d, -0.0253d, 0.23052d, 0.04258d, 4.82082d, 0.01885d, 3.11279d, -0.63338d, 0.10559d, -0.02146d, -0.01672d, 0.03412d, 0.00605d, 0.06415d, -0.89085d, 1.51929d, -0.36571d, 0.39317d, 12.0525d, -3.79392d, 3.96557d, -3.51272d, -0.17953d, 12.30669d, -0.05083d, -0.11442d, 0.02013d, -0.02837d, -0.02087d, -0.01599d, 0.4919d, 0.3036d, 0.01316d, 0.17649d, 0.21193d, -0.09149d, -0.07173d, -0.05707d, 4.24196d, -1.25155d, 1.81336d, 0.68887d, -0.01675d, 0.20772d, -0.04117d, -0.03531d, -0.0269d, -0.02766d, 37.54264d, 10.95327d, 8.0561d, 30.5821d, -12.68257d, 1.72831d, 0.13466d, -3.27007d, 0.01864d, -0.00595d, 0.03676d, 0.14857d, -0.07223d, 0.06179d, 0.44878d, -1.64901d, -20.06001d, 0.63384d, -4.97849d, 4.78627d, 29.8737d, 7.29899d, 0.00047d, -0.00155d, 0.00314d, 0.01425d, -0.17842d, -0.08461d, -1.6102d, -8.4771d, 6.85048d, -4.38196d, 1.05809d, 2.68088d, -0.01027d, -0.00833d, 0.06834d, -0.04205d, 0.0333d, -0.01271d, 0.01301d, -0.01358d, 0.03537d, 0.03612d, 0.02962d, 0.62471d, -0.304d, -0.64857d, 0.01773d, 0.0189d, 0.01426d, -0.00226d, -0.50957d, -0.01955d, -0.09702d, 1.09983d, 0.64387d, -0.02755d, 0.26604d, 0.30684d, 0.06354d, 0.05114d, -0.00058d, -0.04672d, -0.00828d, 0.00712d, -0.0044d, 0.00029d, -0.01601d, 0.03566d, 0.13398d, -0.02666d, -0.06752d, -0.43044d, 0.07172d, -0.01999d, -0.01761d, -0.05357d, 0.06104d, 0.29742d, -0.08785d, 0.05241d, -6.57162d, -4.20103d, 0.03199d, -6.46187d, 1.32846d, -0.51137d, 0.06358d, 0.37309d, -1.46946d, 2.34981d, -0.18712d, 0.11618d, 240.62965d, -107.21962d, 219.81977d, 84.04246d, -62.22931d, 68.35902d, -9.4846d, -32.62906d, 5.57483d, -1.82396d, 1.00095d, -0.39774d, 7.87054d, 11.45449d, -432.67155d, 55064.72398d, 12444.62359d, 54215.28871d, 8486.03749d, 12297.48243d, -333.27968d, 1147.93192d, 1403.73797d, 990.40885d, -3.84938d, -722.43963d, 16.83276d, 96.48787d, 7.04834d, 38.22208d, 0.63843d, 2.61007d, 230.73221d, 171.64166d, 1.96751d, 287.80846d, -85.21762d, 31.33649d, -2.25739d, -11.28441d, 0.04699d, 0.06555d, -0.08887d, 1.70919d, 0.09477d, 0.26291d, -0.1549d, 0.16009d, 1.93274d, 1.01953d, 0.3638d, 1.29582d, -0.13911d, 0.14169d, -0.00491d, -0.0003d, -0.08908d, -0.10216d, -0.03265d, -0.03889d, 0.40413d, -1.12715d, -0.94687d, -0.04514d, 0.02487d, -0.01048d, 0.39729d, 2.82305d, -0.611d, 1.11728d, -0.13083d, -0.04965d, -0.00602d, -0.02952d, -6.13507d, 13.73998d, -15.70559d, -1.28059d, 2.64422d, -9.33798d, 3.2647d, 1.56984d, -0.00572d, 0.09992d, -8.80458d, -8.2389d, -11.51628d, 9.47904d, 11.31646d, 4.29587d, -2.41367d, -0.05883d, -0.80022d, -1.02706d, 0.21461d, -0.06864d, 0.01882d, 0.01798d, 0.27614d, -0.01007d, 0.04362d, 0.0756d, 0.05519d, 0.23435d, -0.09389d, 0.01613d, 0.01298d, 0.04691d, -0.02665d, -0.03582d, 0.6008d, -4.28673d, 1.87316d, -1.0584d, 0.13248d, 0.40887d, -0.67657d, 0.67732d, 0.05522d, 0.07812d, -0.17707d, -0.0751d, 0.24885d, 10.63974d, -7.40226d, -2.33827d, 2.75463d, -32.51518d, 0.0514d, 0.01555d, 180.43808d, 263.28252d, 384.50646d, -76.53434d, -93.50706d, -220.50123d, -81.9161d, 103.92061d, 30.90305d, -2.89292d, -0.06634d, -0.37717d, -0.01945d, -0.05936d, 29.27877d, -59.73705d, 35.86569d, -18.36556d, 3.88812d, 4.8209d, -0.70903d, 0.06615d, 0.01558d, -0.01854d, 0.16209d, 0.12682d, 0.02508d, 0.02406d, -0.03078d, -0.01737d, -0.00033d, -0.0002d, 0.01023d, 0.05972d, -0.03373d, -0.07289d, -2.08162d, -0.14717d, -0.64233d, -0.75397d, 0.11752d, -0.09202d, 4.42981d, -4.19241d, 5.02542d, 5.03467d, -4.22983d, 2.80794d, 3.03016d, -2.74373d, -1.1149d, -2.72378d, -0.63131d, 0.74864d, -0.00759d, -0.00675d, 0.03615d, -0.01806d, -2.7192d, -1.50954d, 0.54479d, -1.92088d, 0.66427d, 0.32228d, -2.55188d, -0.65332d, -2.73798d, 2.10182d, 1.54407d, 3.01357d, 38.76777d, 23.54578d, 27.29884d, -14.93005d, -7.50931d, -5.66773d, 0.30142d, 1.52416d, 0.00634d, 0.09697d, -0.00748d, 0.01433d, 0.02936d, 0.53228d, -0.03603d, 0.06345d, 0.30816d, -1.07925d, 0.46709d, -0.21568d, 0.01663d, 0.1081d, -0.42511d, 0.35872d, -0.19662d, -6.74031d, 1.05776d, 1.86205d, 1.08919d, 0.10483d, -0.03368d, -0.21535d, 0.07556d, -0.27104d, 0.05142d, -0.03812d, 1.20189d, -1.36782d, 1.35764d, 1.39387d, -1.19124d, 0.77347d, -0.5476d, -0.26295d, -0.07473d, 0.23043d, 2.82621d, -0.23524d, 0.47352d, -0.81672d, -0.08515d, 0.047d, 0.55355d, -0.40138d, 0.22255d, 0.12236d, -0.0911d, 0.31982d, 0.39404d, -0.17898d, -0.00056d, 0.00014d, -0.02012d, 0.03102d, 0.43236d, -0.10037d, -0.00961d, 0.0744d, -0.07076d, -1.97272d, 0.25555d, -0.21832d, -0.00837d, -0.08393d, 0.01531d, 0.00627d, 0.33193d, 0.70765d, -0.43556d, 0.28542d, -0.2319d, -0.04293d, -0.08062d, 0.13427d, 0.23763d, -0.17092d, 0.09259d, 0.05155d, 0.08065d, -0.11943d, -0.02174d, -0.68899d, -0.01875d, -0.01746d, 0.13604d, 0.2928d, -0.17871d, 0.11799d, 0.02003d, 0.04065d, 0.01343d, -0.0606d, -0.0129d, -0.26068d, -0.09033d, 0.02649d, -0.00092d, -0.03094d, -0.0077d, -0.10447d, -0.04113d, 0.01259d, -0.00469d, -0.04346d, -0.0001d, 0.06547d };
















































































































































































































































































        internal static double[] tabb = new double[] { -567865.62548d, -796277.29029d, -410804.00791d, -91793.12562d, -6268.13975d, 398.64391d, -710.67442d, 175.29456d, -0.8726d, 0.18444d, -1314.88121d, 20709.97394d, -1850.41481d, 20670.34255d, -896.96283d, 6597.16433d, -179.80702d, 613.45468d, 17.37823d, -13.62177d, -0.36348d, 12.3474d, 0.47532d, 0.48189d, 0.27162d, -0.20655d, -0.23268d, 0.05992d, 46.94511d, 15.78836d, 21.57439d, 23.11342d, -0.25862d, 5.2141d, -0.22612d, -0.05822d, -0.00439d, -0.01641d, -0.01108d, -0.00608d, 0.00957d, 0.00272d, -0.00217d, 0.00001d, -0.00534d, -0.00545d, 0.00277d, -0.00843d, 0.00167d, -0.00794d, 0.00032d, -0.00242d, -0.00002d, -0.00041d, -0.00025d, 0.00031d, 0.00062d, -0.0006d, 0.00083d, 0.00032d, 0.00527d, -0.00211d, 0.00054d, 0.00004d, -0.02769d, -0.01777d, 0.00247d, 0.00097d, 0.0002d, -0.00232d, 0.00044d, -0.00035d, -0.00072d, 0.01341d, 0.00325d, -0.01159d, 0.00079d, -0.00078d, -0.00009d, 0.00066d, 0.00222d, 0.00002d, 0.00013d, -0.00161d, 0.01374d, -0.05305d, 0.00478d, -0.00283d, 0.16033d, 0.13859d, 0.33288d, -0.16932d, -0.00316d, 0.00625d, -0.00309d, 0.01687d, 0.00001d, 0.00486d, 0.00401d, -0.01805d, -0.00048d, -0.00407d, -0.01329d, 0.01311d, -0.00591d, 0.00166d, 0.0083d, 0.00665d, -0.80207d, 0.22994d, -0.34687d, 0.0846d, -0.11499d, -0.01449d, -0.01574d, 0.78813d, -0.03063d, 0.28872d, -0.00337d, 0.01801d, -0.01703d, -0.00929d, -0.00738d, 0.03938d, 0.05616d, -0.00516d, -3.09497d, 30.13091d, -3.14968d, 17.62201d, -0.73728d, 2.46962d, -0.11233d, 0.0345d, -0.07837d, -0.01573d, -0.01595d, 0.00394d, 0.00174d, 0.0147d, 6.8356d, -2.37594d, 4.95125d, 3.24711d, 2.44781d, 5.17159d, 1.9982d, -2.38419d, 0.0084d, 0.03614d, -0.00209d, -0.30407d, -0.02681d, -0.06128d, 1.50134d, 11.82856d, 4.39644d, 6.9885d, -4.17679d, 5.73436d, -9.66087d, 1.98221d, -0.29755d, 0.08019d, -0.24766d, -8.54956d, -1.74494d, -3.36794d, -0.32661d, -0.00722d, 0.14141d, 0.01023d, -1.21541d, -2.5847d, 0.38983d, -1.70307d, 0.31209d, -0.10345d, 0.02593d, 0.02178d, 0.00289d, 0.00393d, -0.00236d, -0.00373d, -0.0027d, -0.00049d, -0.06282d, -0.00443d, -0.02439d, -0.02254d, -0.0222d, 0.03532d, -0.00072d, 0.0001d, -0.00049d, -0.00112d, 0.00086d, 0.00112d, 0.10135d, -0.10972d, 0.08357d, 0.00155d, 0.04363d, -0.00201d, -0.01996d, -0.01341d, -0.00039d, -0.00042d, -0.00294d, 0.0007d, 0.00005d, -0.00027d, 0.0007d, -0.00076d, 0.00234d, -0.00239d, -0.08365d, -0.08531d, -0.03531d, 0.15012d, -0.01995d, -0.01731d, -0.0037d, -0.00745d, -0.00315d, -0.00079d, -0.0012d, -0.00145d, -0.99404d, -1.31859d, 0.03584d, -0.83421d, 0.1072d, -0.05768d, 0.06664d, -0.09338d, -0.01814d, -0.00003d, -0.05371d, -0.06458d, -0.001d, -0.01298d, -7.0871d, -23.13374d, 4.18669d, -19.94756d, 4.85584d, -3.37187d, 0.58851d, 0.31363d, 0.01994d, 0.27494d, -1.37112d, 2.61742d, 0.52477d, -0.4652d, -0.13183d, 0.26777d, 836.904d, -484.65861d, 815.99098d, 236.54649d, -32.38814d, 288.95705d, -68.17178d, -18.87875d, -1.79782d, -3.68662d, -1.2731d, -0.65697d, -3.6753d, 2.10471d, -13758.97795d, 4807.62301d, -14582.14552d, 9019.73021d, -3202.60105d, 4570.16895d, 2078.68911d, 2892.62326d, -2399.35382d, 3253.16198d, -8182.38152d, -3588.7768d, -0.16505d, 1.08603d, 0.53388d, 0.87152d, 61.53677d, 538.43813d, -407.32927d, 322.27446d, -148.71585d, -179.37765d, 54.07268d, -34.12281d, -14.76569d, -17.95681d, -10.82061d, -6.39954d, -2.10954d, 0.67063d, 0.22607d, -0.43648d, 20.90476d, -45.48667d, 30.39436d, -14.20077d, 5.17385d, 5.12726d, -0.66319d, 0.55668d, 0.02269d, -0.00016d, 0.07811d, 0.00111d, 0.01603d, 0.0102d, -0.00107d, 0.00494d, -0.00077d, -0.00084d, -0.00196d, 0.00081d, -0.03776d, 0.01286d, -0.00652d, -0.0145d, 0.05942d, -0.08612d, 0.01093d, -0.01644d, 0.02147d, -0.00592d, 0.3635d, -0.00201d, 0.14419d, -0.1007d, -0.00491d, -0.01771d, -0.00053d, -0.00033d, 0.00146d, 0.00048d, 0.00582d, 0.04423d, -0.00549d, 0.00983d, 0.27355d, -0.38057d, 0.24001d, -0.05441d, -0.07706d, 0.14269d, -0.00059d, -0.00154d, -0.00013d, -0.00088d, -0.00046d, 0.00029d, -0.00276d, -0.00507d, 0.00075d, -0.00076d, 0.01806d, 0.00862d, -0.0051d, -0.01364d, -0.00029d, -0.12664d, 0.03899d, -0.03562d, 0.00318d, 0.00514d, 0.00057d, 0.00201d, 0.00028d, 0.00014d, -0.47022d, -0.74561d, 0.40155d, -0.16471d, -0.18445d, 0.34425d, -0.07464d, -0.13709d, -0.01018d, -0.00748d, -0.0121d, -0.04274d, -0.00579d, -0.00692d, -11.09188d, -1.67755d, -6.62063d, -13.84023d, 12.75563d, -6.73501d, 8.31662d, 5.40196d, 0.00052d, 0.00034d, 0.00128d, 0.00085d, -0.02202d, -0.00599d, -0.33458d, -1.65852d, 1.47003d, -1.02434d, 0.87885d, 1.15334d, -0.00241d, -0.00721d, 0.03154d, 0.00612d, 0.00318d, -0.02521d, 0.00042d, 0.00213d, -0.01094d, 0.05417d, -0.03989d, -0.00567d, 0.00123d, -0.00244d, 0.00108d, 0.00242d, -0.00138d, -0.00099d, 0.04967d, 0.01643d, -0.00133d, 0.02296d, 0.12207d, 0.05584d, 0.00437d, -0.04432d, -0.00176d, -0.00922d, -0.00252d, 0.00326d, -0.0002d, -0.0005d, -0.00263d, -0.00084d, -0.01971d, 0.00297d, 0.03076d, 0.01736d, -0.01331d, 0.01121d, -0.00675d, 0.0034d, -0.00256d, 0.00327d, -0.00946d, 0.03377d, -0.0077d, 0.00337d, 0.61383d, 0.71128d, -0.02018d, 0.62097d, -0.07247d, 0.04418d, -0.02886d, -0.03848d, -0.44062d, 0.03973d, -0.00999d, -0.04382d, 57.94459d, 117.45112d, -71.22893d, 126.39415d, -62.33152d, -31.90754d, 12.17738d, -16.46809d, -1.13298d, 0.08962d, -0.20532d, 0.1632d, -1.5511d, -1.44757d, -3102.08749d, -7452.61957d, -5009.53858d, -7216.29165d, -2476.87148d, -1880.58197d, -574.49433d, 227.45615d, 144.50228d, 379.15791d, 225.3613d, -443.47371d, -8.51989d, -3.75208d, -4.25415d, -1.59741d, -0.43946d, -0.06595d, 150.42986d, 6.54937d, 87.67736d, 92.32332d, -21.97187d, 29.87097d, -4.21636d, -5.72955d, -0.03879d, -0.01071d, -0.45985d, 0.02679d, -0.02448d, 0.02397d, -0.06551d, -0.01154d, 1.97905d, -0.82292d, 1.1014d, 0.30924d, 0.03389d, 0.1423d, 0.00003d, 0.00119d, -0.01117d, 0.00665d, -0.00132d, -0.00576d, -0.08356d, 0.08556d, -0.26362d, -0.1245d, 0.00509d, 0.00165d, 0.02591d, 0.162d, -0.03318d, 0.06463d, -0.00899d, -0.00462d, 0.00102d, 0.00004d, -0.73102d, 0.08299d, -0.52957d, -0.35744d, 0.14119d, -0.24903d, 0.20843d, 0.14143d, 0.00031d, -0.00234d, -0.42643d, -2.02084d, 1.58848d, -1.57963d, 0.68418d, 2.07749d, -0.45888d, 0.19859d, -0.30277d, -0.22591d, 0.11607d, -0.09705d, 0.0004d, 0.00431d, -0.02683d, 0.03158d, -0.01302d, -0.00541d, 0.01742d, -0.00006d, -0.02231d, -0.01128d, -0.008d, 0.02055d, -0.00346d, 0.00151d, 0.56732d, -0.68995d, 0.27701d, -0.16748d, 0.01002d, 0.00043d, 0.26916d, -0.57751d, 0.15547d, -0.15825d, -0.02074d, -0.07722d, -8.23483d, -4.02022d, 0.69327d, -5.91543d, 1.7244d, 1.0209d, 0.00024d, -0.00053d, 20.03959d, 14.79136d, 76.43531d, -14.42019d, -7.82608d, -69.96121d, -54.94229d, 23.5514d, 26.60767d, 14.68275d, 0.05118d, -0.10401d, -0.00075d, -0.01942d, -3.84266d, -26.23442d, 10.20395d, -14.77139d, 3.40853d, 2.07297d, -0.53348d, 0.40635d, 0.00716d, -0.00189d, 0.12472d, -0.02903d, 0.02254d, -0.00183d, -0.00175d, -0.01522d, 0.00003d, -0.00339d, 0.00383d, -0.00168d, 0.01327d, -0.03657d, -0.08458d, -0.00115d, -0.03991d, -0.02629d, 0.00243d, -0.00505d, 0.33875d, -0.16744d, 0.05183d, 0.01744d, -0.24427d, 0.15271d, 0.3755d, -0.17378d, 0.09198d, -0.27966d, -0.2216d, 0.16426d, 0.00032d, -0.0031d, -0.00022d, -0.00144d, -0.0617d, -0.01195d, -0.00918d, 0.02538d, 0.03602d, 0.03414d, -0.14998d, -0.44351d, 0.45512d, -0.11766d, 0.35638d, 0.27539d, 5.93405d, 10.55777d, 12.42596d, -1.8253d, -2.36124d, -6.04176d, -0.98609d, 1.67652d, -0.09271d, 0.03448d, -0.01951d, 0.00108d, 0.33862d, 0.21461d, 0.02564d, 0.06924d, 0.01126d, -0.01168d, -0.00829d, -0.0074d, 0.00106d, -0.00854d, -0.08404d, 0.02508d, -0.02722d, -0.06537d, 0.01662d, 0.11454d, 0.06747d, 0.00742d, -0.01975d, -0.02597d, -0.00097d, -0.01154d, 0.00164d, -0.00274d, 0.02954d, -0.05161d, -0.02162d, -0.02069d, -0.06369d, 0.03846d, 0.00219d, -0.01634d, -0.04518d, 0.06696d, 1.21537d, 0.995d, 0.68376d, -0.28709d, -0.11397d, -0.06468d, 0.00607d, -0.00744d, 0.01531d, 0.00975d, -0.03983d, 0.02405d, 0.07563d, 0.00356d, -0.00018d, -0.00009d, 0.00172d, -0.00331d, 0.01565d, -0.03466d, -0.0023d, 0.00142d, -0.00788d, -0.01019d, 0.01411d, -0.01456d, -0.00672d, -0.00543d, 0.00059d, -0.00011d, -0.00661d, -0.00496d, -0.01986d, 0.01271d, -0.01323d, -0.00764d, 0.00041d, 0.01145d, 0.00378d, -0.00137d, 0.00652d, 0.00412d, 0.01946d, -0.00573d, -0.00326d, -0.00257d, -0.00225d, 0.0009d, -0.00292d, -0.00317d, -0.00719d, 0.00468d, 0.00245d, 0.00189d, 0.00565d, -0.0033d, -0.00168d, -0.00047d, -0.00256d, 0.0022d, 0.0018d, -0.00162d, -0.00085d, -0.00003d, -0.001d, 0.00098d, -0.00043d, 0.00007d, -0.00003d, -0.00013d };
















































































































































































































































































        internal static double[] tabr = new double[] { -38127.94034d, -48221.08524d, -20986.93487d, -3422.75861d, -8.97362d, 53.34259d, -404.15708d, -0.05434d, 0.46327d, 0.16968d, -387.16771d, -146.07622d, 103.77956d, 19.11054d, -40.21762d, 996.16803d, -702.22737d, 246.36496d, -63.89626d, -304.82756d, 78.23653d, -2.58314d, -0.11368d, -0.06541d, -0.34321d, 0.33039d, 0.05652d, -0.16493d, 67.44536d, -29.43578d, 50.85074d, 18.68861d, 0.39742d, 13.64587d, -1.61284d, 0.11482d, 0.01668d, -0.01182d, -0.00386d, 0.01025d, 0.00234d, -0.0153d, -0.02569d, -0.00799d, -0.00429d, -0.00217d, -0.00672d, 0.0065d, 0.01154d, 0.0012d, -0.00515d, 0.00125d, 0.00236d, -0.00216d, -0.00098d, 0.00009d, -0.0046d, -0.00518d, 0.006d, 0.00003d, 0.00834d, 0.00095d, 0.01967d, 0.00637d, -0.00558d, -0.06911d, -0.01344d, -0.06589d, -0.05425d, -0.00607d, -0.00247d, -0.00266d, 0.0879d, -0.08537d, -0.00647d, 0.04028d, -0.00325d, 0.00488d, 0.00111d, -0.00044d, -0.00731d, 0.00127d, -0.00417d, 0.00303d, 0.05261d, 0.01858d, -0.00807d, 0.01195d, 1.26352d, -0.38591d, -0.34825d, 1.10733d, -0.02815d, -0.02148d, -0.05083d, -0.04377d, -0.01206d, -0.00586d, 0.03158d, -0.01117d, 0.00643d, 0.00306d, -0.01186d, -0.05161d, 0.01136d, -0.00976d, -0.00536d, 0.01949d, -1.4168d, -0.8129d, -0.09254d, -0.24347d, -0.14831d, -0.34381d, -2.44464d, 0.41202d, -0.9924d, -0.33707d, -0.0193d, -0.08473d, 0.0083d, 0.01165d, -0.01604d, -0.02439d, 0.00227d, 0.04493d, -42.7531d, -22.65155d, -9.93679d, -18.36179d, 2.73773d, 3.24126d, -1.20698d, 1.07731d, 0.00434d, -0.1036d, -0.02359d, 0.00054d, -0.02664d, -0.00122d, -19.7952d, 33.1177d, -53.56452d, -35.41902d, 67.95039d, -82.46551d, 117.31843d, 14.08609d, 0.06447d, 0.03289d, 0.40365d, -0.33397d, 0.07079d, -0.09504d, -30.36873d, 6.23538d, -14.25988d, -44.91408d, 38.53146d, -16.31919d, 6.99584d, 22.47169d, -0.13313d, 0.28016d, 6.83715d, -6.01384d, 1.68531d, -3.62443d, -0.22469d, -0.29718d, 0.25169d, 0.1378d, -3.64824d, 1.2242d, -2.48963d, -1.12515d, -0.0151d, -0.5618d, -0.03306d, 0.01848d, -0.00103d, -0.00077d, -0.01681d, -0.00227d, -0.00402d, -0.00287d, 0.04965d, -0.1619d, -0.40025d, 0.20734d, 0.15819d, -0.25451d, 0.02467d, -0.00495d, 0.00597d, 0.0049d, -0.01085d, -0.0046d, -0.71564d, -0.26624d, 0.03797d, -0.28263d, 0.0351d, 0.30014d, 2.7981d, 0.07258d, -0.01618d, 0.00337d, 0.00876d, 0.04438d, 0.00742d, -0.00455d, -0.01163d, -0.00683d, 0.0095d, 0.01275d, -0.02124d, -0.67527d, -0.23635d, 0.06298d, -0.03844d, 0.0101d, 0.73588d, -0.00271d, 0.01742d, -0.00467d, 0.00017d, -0.00505d, -0.27482d, 5.00521d, -1.92099d, 1.55295d, -0.35919d, -0.09314d, -0.47002d, 0.06826d, 0.07924d, 0.16838d, -0.04221d, 0.7151d, -0.16482d, 0.08809d, 41.76829d, -125.79427d, 106.65271d, -71.30642d, 36.18112d, 17.36143d, -1.63846d, 5.02215d, -1.08404d, 0.00061d, 2.45567d, -2.42818d, -9.88756d, 5.36587d, -0.61253d, -0.35003d, 1523.5479d, 602.82184d, 68.66902d, 1878.261d, -1098.78095d, -120.726d, 127.30918d, -383.96064d, -7.00838d, -6.09942d, -1.54187d, 0.34883d, -9.47561d, -4.35408d, -21541.63676d, -32542.09807d, -29720.82604d, -28072.21231d, -15755.56255d, -8084.58657d, -8148.87315d, 7434.89857d, 11033.30133d, 7827.94658d, 610.18256d, -11411.93624d, -9.87426d, 0.94865d, -1.63656d, 0.41275d, 1996.5715d, 511.48468d, 669.78228d, 1363.6761d, -379.72037d, 198.84438d, -16.63126d, -79.37624d, -2.30776d, -246.0782d, -16.85846d, -148.18168d, -6.89632d, -20.49587d, 0.39892d, -0.34627d, -57.81309d, -136.96971d, 15.25671d, -96.61153d, 16.09785d, -8.79091d, 0.70515d, 1.16197d, 0.05647d, 0.04684d, 0.25032d, -0.19951d, 0.07282d, -0.00696d, 0.00493d, 0.00733d, -0.01085d, 0.00422d, -0.01309d, 0.00262d, 0.37616d, -0.36203d, -0.11154d, 0.18213d, 0.15691d, 0.29343d, 0.00485d, 0.06106d, -0.01492d, 0.09954d, 0.28486d, 2.2719d, 0.33102d, 1.50696d, -0.01926d, 0.04901d, 0.01827d, 0.00863d, -0.03315d, 0.00178d, -0.776d, -0.48576d, -0.21111d, -0.19485d, 1.90295d, 6.44856d, 1.71638d, 2.1298d, -7.19585d, -0.08043d, 0.07004d, -0.02764d, 0.01604d, 0.01158d, 0.00936d, -0.01199d, 0.18396d, -0.29234d, 0.10422d, -0.0072d, 0.05196d, 0.10753d, 0.02859d, -0.03602d, 0.63828d, 1.9628d, -0.31919d, 0.85859d, -0.10218d, -0.00673d, 0.01748d, -0.0219d, 0.01266d, -0.02729d, -4.8022d, 8.90557d, -5.94059d, 2.28577d, -0.19687d, -1.28666d, 0.32398d, 0.14879d, -0.02619d, -0.02056d, -0.04872d, -0.07011d, -0.04082d, -0.0474d, 0.60167d, -2.20365d, -0.27919d, -0.45957d, -1.31664d, -2.22682d, 176.89871d, 13.03918d, 0.00568d, 0.0056d, 0.01093d, 0.00486d, -0.00948d, -0.31272d, -11.87638d, -3.68471d, -1.74977d, -9.60468d, 2.94988d, -0.57118d, 0.00307d, -0.01636d, 0.02624d, 0.03032d, -0.00464d, -0.01338d, 0.00935d, 0.0053d, -0.11822d, 0.03328d, -0.41854d, 0.04331d, 0.4134d, -0.21657d, -0.00865d, 0.00849d, -0.00374d, -0.00899d, 0.01227d, -0.23462d, -0.71894d, -0.04515d, 0.00047d, 0.28112d, -0.12788d, 0.11698d, -0.0203d, 0.02759d, 0.02967d, -0.00092d, 0.00454d, 0.00565d, -0.00026d, 0.00164d, -0.01405d, -0.00862d, 0.01088d, 0.05589d, 0.18248d, -0.06931d, -0.00011d, 0.03713d, 0.01932d, -0.00982d, -0.13861d, 0.09853d, -0.03441d, -0.02492d, 2.26163d, -5.94453d, 4.14361d, -0.94105d, 0.39561d, 0.75414d, -0.17642d, 0.03724d, -1.32978d, -0.5661d, -0.03259d, -0.06752d, 39.07495d, 80.25429d, -28.15558d, 82.69851d, -37.53894d, -17.88963d, 6.98299d, -13.04691d, -0.48675d, -1.8453d, -0.07985d, -0.33004d, -3.39292d, 2.73153d, -17268.46134d, 1144.22336d, -16658.48585d, 5252.94094d, -3461.47865d, 2910.56452d, -433.49442d, -305.74268d, -383.45023d, 545.16136d, 313.83376d, 27.00533d, -31.41075d, 7.9057d, -12.40592d, 3.01833d, -0.83334d, 0.23404d, 59.26487d, -112.74279d, 113.29402d, -15.37579d, 14.03282d, 32.74482d, -4.73299d, 1.30224d, -0.00866d, 0.01232d, -0.53797d, 0.00238d, -0.07979d, 0.04443d, -0.05617d, -0.05396d, 0.10185d, -1.05476d, 0.43791d, -0.32302d, 0.06465d, 0.03815d, 0.00028d, -0.00446d, 0.09289d, -0.06389d, 0.01701d, -0.01409d, 0.47101d, 0.16158d, 0.01036d, -0.39836d, 0.00477d, 0.01101d, -2.06535d, 0.33197d, -0.82468d, -0.41414d, 0.03209d, -0.09348d, 0.00843d, -0.0003d, -9.49517d, -3.82206d, 0.66899d, -10.28786d, 6.33435d, 1.73684d, -0.98164d, 2.25164d, -0.07577d, -0.00277d, 1.02122d, 0.75747d, 1.79155d, -0.77789d, -2.5678d, -2.07807d, 0.19528d, 0.77118d, -0.28083d, 0.3213d, -0.0435d, -0.07428d, -0.01161d, 0.01387d, 0.02074d, 0.19802d, -0.036d, 0.04922d, -0.19837d, 0.02572d, -0.00682d, -0.04277d, -0.01805d, 0.00299d, 0.03283d, -0.02099d, 3.57307d, 1.17468d, 0.65769d, 1.88181d, -0.39215d, 0.08415d, -0.53635d, -0.19087d, -0.12456d, 0.02176d, 0.01182d, -0.07941d, -2.43731d, 2.44464d, 1.03961d, -1.81936d, 30.3314d, 0.92645d, 0.00508d, -0.01771d, -81.06338d, 66.43957d, 33.16729d, 131.44697d, 76.63344d, -34.34324d, -35.33012d, -28.04413d, -1.4744d, 13.09015d, 0.13253d, -0.01629d, 0.02187d, -0.00963d, -21.4747d, -9.44332d, -7.21711d, -12.59472d, 1.76195d, -1.63911d, 0.0906d, 0.28656d, 0.00635d, 0.00536d, 0.0347d, -0.06493d, 0.00666d, -0.01084d, 0.01116d, -0.01612d, -0.00102d, 0.00208d, -0.05568d, 0.00628d, 0.02665d, -0.01032d, 0.21261d, -1.90651d, 0.72728d, -0.57788d, 0.08662d, 0.10918d, 3.39133d, 3.97302d, -4.63381d, 4.2667d, -2.50873d, -3.76064d, 1.28114d, 1.81919d, 1.48064d, -0.37578d, -0.26209d, -0.47187d, 0.00282d, -0.00499d, 0.01749d, 0.03222d, 1.60521d, -1.79705d, 1.61453d, 0.68886d, -0.29909d, 0.55025d, -0.07894d, 0.1988d, -0.15635d, 0.46159d, 2.09769d, 1.52742d, -7.60312d, 11.34886d, 4.3564d, 8.61048d, 2.15001d, -2.15303d, -0.61587d, -0.1195d, -0.03289d, -0.0052d, -0.00501d, -0.00445d, 0.15294d, -0.05277d, 0.02455d, 0.00408d, 1.19601d, 0.43479d, 0.20422d, 0.57125d, -0.1279d, 0.01318d, -0.15275d, -0.43856d, 6.99144d, -0.08794d, -1.69865d, 0.82589d, -0.20235d, 0.9704d, 0.20903d, 0.00675d, 0.26943d, 0.08281d, 0.03686d, 0.05311d, 1.28468d, 1.21735d, -1.38174d, 1.2957d, -0.75899d, -1.17168d, 0.44696d, -0.32341d, -0.06378d, -0.27573d, -0.06406d, 0.87186d, 0.21069d, 0.19724d, 0.00119d, -0.04147d, 0.39279d, 0.51437d, -0.11035d, 0.2145d, -0.04309d, 0.02359d, 0.2049d, 0.1421d, 0.00007d, -0.00017d, -0.03529d, -0.02644d, 0.1071d, 0.44476d, -0.02632d, -0.01817d, 2.11335d, -0.04432d, 0.18206d, 0.27335d, 0.08867d, 0.00313d, -0.00692d, 0.01595d, -0.72957d, 0.3208d, -0.29291d, -0.44764d, 0.12767d, -0.05778d, 0.04797d, -0.00223d, 0.17661d, 0.22427d, -0.04914d, 0.09114d, 0.12236d, 0.00708d, 0.74315d, -0.01346d, 0.02245d, -0.02555d, -0.30446d, 0.13947d, -0.1234d, -0.18498d, -0.04099d, 0.02103d, 0.06337d, -0.01224d, 0.28181d, -0.01019d, -0.02794d, -0.09412d, 0.03272d, -0.01095d, 0.11247d, -0.0065d, -0.01319d, -0.04296d, 0.04653d, -0.00423d, 0.06535d, 0.00014d };
















































































































































































































































































        internal static int[] args = new int[] { 0, 7, 3, 2, 5, -6, 6, 3, 7, 0, 2, 2, 5, -5, 6, 5, 3, 1, 6, -4, 7, 2, 8, 0, 2, 1, 6, -3, 7, 0, 3, 1, 6, -2, 7, -2, 8, 0, 2, 4, 5, -10, 6, 3, 3, 1, 5, -1, 6, -4, 7, 0, 3, 2, 5, -4, 6, -3, 7, 0, 3, 2, 6, -8, 7, 4, 8, 0, 3, 3, 5, -10, 6, 7, 7, 0, 2, 6, 5, -15, 6, 0, 2, 2, 6, -6, 7, 0, 3, 1, 5, -4, 6, 4, 7, 1, 3, 1, 5, -2, 6, -1, 7, 0, 3, 2, 5, -5, 6, 1, 8, 0, 3, 3, 5, -8, 6, 2, 7, 0, 3, 1, 5, -3, 6, 2, 8, 0, 3, 1, 5, -3, 6, 1, 7, 1, 1, 1, 8, 0, 3, 1, 5, -3, 6, 2, 7, 1, 3, 1, 5, -2, 6, -2, 7, 0, 2, 2, 6, -5, 7, 1, 3, 2, 6, -6, 7, 2, 8, 0, 3, 2, 6, -7, 7, 4, 8, 0, 3, 2, 5, -4, 6, -2, 7, 0, 3, 1, 5, -1, 6, -5, 7, 0, 3, 2, 6, -7, 7, 5, 8, 0, 3, 1, 6, -1, 7, -2, 8, 0, 2, 1, 6, -2, 7, 1, 3, 1, 6, -3, 7, 2, 8, 0, 3, 1, 6, -4, 7, 4, 8, 1, 3, 2, 5, -5, 6, 2, 8, 1, 3, 2, 5, -6, 6, 2, 7, 1, 2, 2, 7, -2, 8, 0, 1, 1, 7, 2, 2, 5, 5, -12, 6, 2, 3, 2, 6, -5, 7, 1, 8, 0, 3, 1, 5, -1, 6, -3, 7, 0, 3, 7, 5, -18, 6, 3, 7, 0, 2, 3, 5, -7, 6, 3, 3, 1, 6, 1, 7, -5, 8, 0, 3, 1, 5, -4, 6, 3, 7, 0, 3, 5, 5, -13, 6, 3, 7, 0, 2, 1, 5, -2, 6, 3, 3, 3, 5, -9, 6, 3, 7, 0, 3, 3, 5, -8, 6, 3, 7, 1, 2, 1, 5, -3, 6, 3, 3, 5, 5, -14, 6, 3, 7, 0, 3, 1, 5, -3, 6, 3, 7, 2, 2, 3, 6, -7, 7, 0, 2, 3, 5, -8, 6, 2, 3, 2, 5, -3, 6, -4, 7, 1, 3, 2, 5, -8, 6, 7, 7, 0, 2, 5, 5, -13, 6, 0, 2, 2, 6, -4, 7, 2, 3, 2, 6, -5, 7, 2, 8, 0, 3, 2, 5, -4, 6, -1, 7, 0, 3, 2, 5, -7, 6, 4, 7, 0, 2, 1, 6, -2, 8, 2, 2, 1, 6, -1, 7, 0, 3, 1, 6, -2, 7, 2, 8, 0, 3, 2, 5, -5, 6, 2, 7, 0, 3, 2, 5, -6, 6, 2, 8, 0, 3, 2, 5, -6, 6, 1, 7, 0, 2, 3, 7, -2, 8, 0, 1, 2, 7, 1, 2, 1, 6, -1, 8, 1, 3, 1, 5, -2, 6, 1, 7, 0, 3, 1, 5, -2, 6, 2, 8, 0, 2, 3, 6, -6, 7, 2, 2, 6, 5, -14, 6, 0, 3, 3, 6, -7, 7, 2, 8, 0, 3, 2, 5, -3, 6, -3, 7, 1, 2, 4, 5, -9, 6, 3, 3, 2, 6, -2, 7, -2, 8, 0, 2, 2, 6, -3, 7, 1, 3, 2, 6, -4, 7, 2, 8, 0, 2, 2, 5, -4, 6, 3, 3, 2, 5, -7, 6, 3, 7, 1, 3, 1, 6, 1, 7, -2, 8, 0, 1, 1, 6, 5, 3, 2, 5, -5, 6, 3, 7, 1, 2, 2, 5, -6, 6, 3, 1, 3, 7, 3, 2, 4, 5, -11, 6, 3, 2, 1, 5, -4, 7, 0, 3, 2, 5, -5, 6, -3, 7, 1, 2, 6, 5, -16, 6, 0, 3, 3, 5, -7, 6, 2, 7, 0, 3, 3, 6, -4, 7, -2, 8, 0, 2, 3, 6, -5, 7, 1, 3, 3, 6, -6, 7, 2, 8, 1, 3, 3, 6, -7, 7, 4, 8, 0, 3, 2, 5, -3, 6, -2, 7, 2, 3, 2, 5, -8, 6, 5, 7, 0, 2, 2, 6, -4, 8, 0, 3, 2, 6, -1, 7, -2, 8, 1, 2, 2, 6, -2, 7, 2, 3, 2, 6, -3, 7, 2, 8, 0, 3, 2, 5, -4, 6, 1, 7, 0, 3, 2, 5, -4, 6, 2, 8, 0, 3, 2, 5, -7, 6, 2, 7, 1, 2, 1, 6, 1, 7, 1, 2, 5, 5, -11, 6, 2, 3, 1, 5, -2, 7, -2, 8, 0, 2, 1, 5, -3, 7, 0, 2, 3, 5, -6, 6, 3, 3, 2, 6, 1, 7, -5, 8, 0, 2, 2, 6, -3, 8, 1, 2, 1, 5, -1, 6, 3, 3, 2, 5, -7, 6, 3, 8, 0, 3, 3, 5, -7, 6, 3, 7, 0, 3, 2, 5, -1, 6, -7, 7, 0, 2, 1, 5, -4, 6, 2, 3, 1, 5, -2, 6, 3, 7, 0, 2, 4, 6, -7, 7, 0, 2, 3, 5, -9, 6, 0, 3, 2, 5, -2, 6, -4, 7, 0, 2, 3, 6, -4, 7, 2, 3, 2, 5, -3, 6, -1, 7, 0, 3, 2, 5, -8, 6, 4, 7, 0, 2, 2, 6, -2, 8, 1, 2, 2, 6, -1, 7, 0, 3, 2, 6, -2, 7, 2, 8, 1, 3, 2, 5, -4, 6, 2, 7, 0, 3, 2, 5, -7, 6, 2, 8, 0, 3, 2, 5, -7, 6, 1, 7, 0, 2, 1, 6, 2, 7, 0, 2, 2, 6, -1, 8, 0, 2, 4, 6, -6, 7, 1, 2, 6, 5, -13, 6, 0, 3, 2, 5, -2, 6, -3, 7, 1, 2, 4, 5, -8, 6, 2, 3, 3, 6, -2, 7, -2, 8, 0, 2, 3, 6, -3, 7, 0, 3, 3, 6, -4, 7, 2, 8, 0, 2, 2, 5, -3, 6, 3, 3, 2, 5, -8, 6, 3, 7, 1, 3, 2, 6, 1, 7, -2, 8, 0, 1, 2, 6, 5, 3, 2, 5, -4, 6, 3, 7, 2, 2, 2, 5, -7, 6, 3, 3, 1, 6, 4, 7, -2, 8, 0, 2, 1, 6, 3, 7, 1, 3, 1, 6, 2, 7, 2, 8, 0, 2, 4, 5, -12, 6, 2, 2, 5, 6, -8, 7, 0, 2, 4, 6, -5, 7, 0, 3, 2, 5, -2, 6, -2, 7, 0, 2, 3, 6, -2, 7, 1, 3, 3, 6, -3, 7, 2, 8, 0, 2, 5, 5, -10, 6, 2, 3, 1, 5, 1, 6, -3, 7, 0, 2, 3, 5, -5, 6, 3, 2, 3, 6, -3, 8, 0, 1, 1, 5, 2, 2, 1, 5, -5, 6, 2, 2, 5, 6, -7, 7, 0, 2, 4, 6, -4, 7, 2, 2, 3, 6, -2, 8, 0, 2, 3, 6, -1, 7, 0, 2, 5, 6, -6, 7, 0, 2, 4, 5, -7, 6, 2, 2, 4, 6, -3, 7, 2, 2, 2, 5, -2, 6, 2, 3, 2, 6, -9, 7, 3, 8, 0, 1, 3, 6, 4, 3, 2, 5, -3, 6, 3, 7, 1, 2, 2, 5, -8, 6, 3, 3, 2, 6, 4, 7, -2, 8, 0, 2, 4, 5, -13, 6, 1, 2, 6, 6, -8, 7, 1, 2, 5, 6, -5, 7, 0, 2, 4, 6, -2, 7, 0, 2, 5, 5, -9, 6, 2, 2, 3, 5, -4, 6, 2, 2, 1, 5, 1, 6, 2, 2, 6, 5, -11, 6, 0, 3, 6, 6, -7, 7, 2, 8, 0, 2, 4, 5, -6, 6, 2, 2, 2, 5, -1, 6, 2, 1, 4, 6, 3, 3, 2, 5, -2, 6, 3, 7, 1, 2, 2, 5, -9, 6, 1, 2, 5, 5, -8, 6, 2, 2, 3, 5, -3, 6, 1, 2, 1, 5, 2, 6, 2, 2, 6, 5, -10, 6, 1, 2, 4, 5, -5, 6, 2, 1, 2, 5, 1, 1, 5, 6, 2, 2, 5, 5, -7, 6, 1, 2, 3, 5, -2, 6, 1, 3, 1, 5, 2, 6, 3, 7, 0, 2, 6, 5, -9, 6, 0, 2, 4, 5, -4, 6, 2, 2, 2, 5, 1, 6, 1, 2, 7, 5, -11, 6, 0, 2, 5, 5, -6, 6, 1, 2, 3, 5, -1, 6, 1, 2, 6, 5, -8, 6, 1, 2, 4, 5, -3, 6, 0, 2, 5, 5, -5, 6, 0, 1, 3, 5, 0, 2, 6, 5, -7, 6, 1, 2, 7, 5, -9, 6, 0, 2, 5, 5, -4, 6, 0, 2, 6, 5, -6, 6, 0, 2, 7, 5, -8, 6, 0, 2, 6, 5, -5, 6, 0, 2, 7, 5, -7, 6, 0, 2, 8, 5, -9, 6, 0, 2, 8, 5, -8, 6, 0, 2, 1, 3, -1, 6, 0, -1 };
























































































































































































































        // /* Total terms = 215, small = 211 */
        internal static KeplerGlobalCode.plantbl sat404 = new KeplerGlobalCode.plantbl(9, new int[19] { 0, 0, 1, 0, 8, 18, 9, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 7, args, tabl, tabb, tabr, 9.55758135486d, 3652500.0d, 1.0d);










    }
}