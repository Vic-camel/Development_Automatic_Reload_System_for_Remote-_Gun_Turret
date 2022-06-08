using System;
using System.Runtime.InteropServices;

namespace HIWIN
{
    // 參考資訊：HIWIN HRMB.DLL使用手（版本：V1.0.0；日期2016.1）
    // 本類別檔案建立日期：108年12月11日
    // 最後新日期：108年12月11日
    /*
     * 更新log：
     */

    public class RA605
    {
        #region 3.1. 連線命令 (p. 13)
        // 3.1.1. 建立連線：(p. 14)
        [DllImport("HRSDK_x64.dll")]
        public static extern int Connect(String cmd);

        // 3.1.2. 關閉連線：(p. 14)
        [DllImport("HRSDK_x64.dll")]
        public static extern void Close(int robot);
        #endregion

        #region 3.2. 設定命令 (p. 14)
        // 3.2.1. 設定加速度比例：(p. 14)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_acc_dec_ratio(int robot , int acc);

        // 3.2.2. 取得加速度比例：(p. 14)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_acc_dec_ratio(int robot);

        // 3.2.3. 取得加速度比例(RG)：(p. 15)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_acc_dec_ratioRG(int robot);

        // 3.2.4. 設定點對點運動速度：(p. 15)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_ptp_speed(int robot, int vel);

        // 3.2.5. 取得點對點運動速度：(p. 16)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_ptp_speed(int robot);

        // 3.2.6. 取得點對點運動速度(RG)：(p. 16)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_ptp_speedRG(int robot );

        // 3.2.7. 設定直線運動速度：(p. 16)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_lin_speed(int robot, double vel);

        // 3.2.8. 取得直線運動速度：(p. 17)
        [DllImport("HRSDK_x64.dll")]
        public static extern double get_lin_speed(int robot);

        // 3.2.9. 取得直線運動速度(RG)：(p. 17)
        [DllImport("HRSDK_x64.dll")]
        public static extern double get_lin_speedRG(int robot );

        // 3.2.10. 設定進給速度：(p. 17)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_override_ratio(int robot, int vel);

        // 3.2.11. 取得進給速度：(p. 17)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_override_ratio(int robot);

        // 3.2.12. 取得進給速度(RG)：(p. 18)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_override_ratioRG(int robot);

        // 3.2.13. 設定工具號碼：(p. 18)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_tool_number(int robot, int num);

        // 3.2.14. 取得工具號碼：(p. 18)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_tool_number(int robot);

        // 3.2.15. 定義工具座標：(p. 19)
        [DllImport("HRSDK_x64.dll")]
        public static extern int define_tool(int robot, int toolNum, double[] coor);

        // 3.2.16. 取得工具座標：(p. 19)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_tool_data(int robot, int num, double[] coor);

        // 3.2.17. 設定基底號碼：(p. 19)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_base_number(int robot, int baseNum, int num);

        // 3.2.18. 取得基底號碼：(p. 20)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_base_number(int robot);

        // 3.2.19. 定義基底座標：(p. 20)
        [DllImport("HRSDK_x64.dll")]
        public static extern int define_base(int robot, int baseNum, double[] coor);

        // 3.2.20. 取得基底座標：(p. 20)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_base_data(int robot, int num, double[] coor);

        // 3.2.21. 工具座標量測點紀錄：(p. 21)
        [DllImport("HRSDK_x64.dll")]
        public static extern int tool_correct_measure(int robot, int toolNum, int pointNum);

        // 3.2.22. 工具座標量測點計算：(p. 22)
        [DllImport("HRSDK_x64.dll")]
        public static extern int tool_correct_calculate(int robot, int toolNum);

        // 3.2.23. 基底座標量測點紀錄： (p. 23)
        [DllImport("HRSDK_x64.dll")]
        public static extern int base_correct_measure(int robot, int baseNum, int pointNum);

        // 3.2.24. 基底座標量測點計算： (p. 23)
        [DllImport("HRSDK_x64.dll")]
        public static extern int base_correct_calculate(int robot, int baseNum);

        // 3.2.25. 伺服設定：(p. 24)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_motor_state(int robot, int state);

        // 3.2.26. 取得伺服狀態：(p. 24)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_motor_state(int robot);

        // 3.2.27. 機器手臂校正：(p. 24)
        [DllImport("HRSDK_x64.dll")]
        public static extern int mastering(int robot, int joint);

        // 3.2.28. 設定操作模式：(p. 25)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_mode(int robot, int mode);

        // 3.2.29. 取得操作模式：(p. 25)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_mode(int robot);

        // 3.2.30. 錯誤清除：(p. 26)
        [DllImport("HRSDK_x64.dll")]
        public static extern int controller_rest(int robot);

        // 3.2.31. 設定位置暫存器資料： (p. 26)
        // Hint: default variable "base" idchanged to "c_base"
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_pr(int robot, int prNum, int coorType, double[] coor, int tool, int c_base);

        // 3.2.32. 取得位置暫存器形態：(p. 26)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_pr_type(int robot , int prNum);

        // 3.2.33. 取得位置暫存器座標：(p. 27)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_pr_coordinate(int robot, int pr, double[] coor);

        // 3.2.34. 取得位置暫存器工具、基底座標：(p. 27)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_pr_tool_base(int robot, int pr, int[] tool_base);
        #endregion

        #region 3.3. 運動命令 (p. 28)
        // 3.3.1. 絕對座標位置點對點運動：
        [DllImport("HRSDK_x64.dll")]
        public static extern int ptp_pos(int robot , double[] p);
        
        // 3.3.2. 絕對關節角度點運動：(p. 28)
        //[DllImport("HRSDK_x64.dll", EntryPoint = "ptp_axis")] // 範例：自定義副函數名稱對應dll函數名稱
       [DllImport("HRSDK_x64.dll")]
        public static extern int ptp_axis(int robot, double[] point);

        // 3.3.3. 相對座標位置點對點運動：(p. 29)
        [DllImport("HRSDK_x64.dll")]
        public static extern int ptp_rel_pos(int robot , double[] p);

        // 3.3.4. 相對關節角度點對點運動：(p. 29)
        [DllImport("HRSDK_x64.dll")]
        public static extern int ptp_rel_axis(int robot , double[] p);

        // 3.3.5. 教導點之點對點運動：(p. 29)
         [DllImport("HRSDK_x64.dll")]
        public static extern int ptp_point(int robot, int p);

        // 3.3.6. 絕對座標位置直線運動：(p. 30)
        [DllImport("HRSDK_x64.dll")]
        public static extern int lin_pos(int robot , double[] p);

        // 3.3.7. 絕對關節角度直線運動：(p. 30)
        [DllImport("HRSDK_x64.dll")]
        public static extern int lin_axis(int robot , double[] p);

        // 3.3.8. 相對座標位置直線運動：(p. 31)
        [DllImport("HRSDK_x64.dll")]
        public static extern int lin_rel_pos(int robot, double[] p);

        // 3.3.9. 相對關節角度直線運動：(p. 31)
        [DllImport("HRSDK_x64.dll")]
        public static extern int lin_rel_axis(int robot, double[] p);

        // 3.3.10. 教導點之直線運動：(p. 31)
        [DllImport("HRSDK_x64.dll")]
        public static extern int lin_point(int robot, int p);

        // 3.3.11. 設定圓弧運動之圓弧點：(p. 32)
        [DllImport("HRSDK_x64.dll")]
        public static extern int circ_set_aux_pos(int robot, double[] p);

        // 3.3.12. 設定圓弧運動之終點：(p. 32)
        [DllImport("HRSDK_x64.dll")]
        public static extern int circ_set_end_pos(int robot, double[] p);

        // 3.3.13. 絕對座標位置圓弧運動：(p. 33)
        [DllImport("HRSDK_x64.dll")]
        public static extern int circ_pos(int robot);

        // 3.3.14. 教導點之圓弧運動：(p. 33)
        [DllImport("HRSDK_x64.dll")]
        public static extern int circ_point(int robot, int p1, int p2);

        // 3.3.15. 運動暫停：(p. 33)
        [DllImport("HRSDK_x64.dll")]
        public static extern int motion_hold(int robot);

        // 3.3.16. 運動繼續：(p. 33)
        [DllImport("HRSDK_x64.dll")]
        public static extern int motion_continue(int robot);

        // 3.3.17. 運動停止：(p. 34)
        [DllImport("HRSDK_x64.dll")]
        public static extern int motion_abort(int robot);

        // 3.3.18. 運動延遲：(p. 34)
        [DllImport("HRSDK_x64.dll")]
        public static extern int motion_delay(int robot, int delay);

        // 3.3.19. 設定平滑半徑：(p. 34)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_smooth_length(int robot, int r);

        // 3.3.20. 設定運動命令編號：(p. 35)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_com_id(int robot, int id);

        // 3.3.21. 取得運動命令編號：(p. 35)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_com_id(int robot, int[] motionID);

        // 3.3.22. 取得運動命令編號(RG)：(p. 36)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_com_idRG(int robot, int[] motionID);
        #endregion

        #region 3.4. 吋動與教導命令 (p. 36)
        // 3.4.1. 連續移動：(p. 37)
            #region 關節座標
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint1P(int robot); // 關節軸1正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint1R(int robot); // 關節軸1反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint2P(int robot); // 關節軸2正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint2R(int robot); // 關節軸2反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint3P(int robot); // 關節軸3正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint3R(int robot); // 關節軸3反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint4P(int robot); // 關節軸4正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint4R(int robot); // 關節軸4反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint5P(int robot); // 關節軸5正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint5R(int robot); // 關節軸5反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint6P(int robot); // 關節軸6正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_joint6R(int robot); // 關節軸6反向吋動
        #endregion

            #region 笛卡爾座標
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart1P(int robot); // 笛卡爾座標X正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart1R(int robot); // 笛卡爾座標X反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart2P(int robot); // 笛卡爾座標Y正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart2R(int robot); // 笛卡爾座標Y反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart3P(int robot); // 笛卡爾座標Z正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart3R(int robot); // 笛卡爾座標Z反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart4P(int robot); // 笛卡爾座標U正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart4R(int robot); // 笛卡爾座標U反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart5P(int robot); // 笛卡爾座標V正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart5R(int robot); // 笛卡爾座標V反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart6P(int robot); // 笛卡爾座標W正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_cart6R(int robot); // 笛卡爾座標W反向吋動
        #endregion

            #region 工具座標
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool1P(int robot); // 工具座標X正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool1R(int robot); // 工具座標X反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool2P(int robot); // 工具座標Y正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool2R(int robot); // 工具座標Y反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool3P(int robot); // 工具座標Z正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool3R(int robot); // 工具座標Z反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool4P(int robot); // 工具座標U正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool4R(int robot); // 工具座標U反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool5P(int robot); // 工具座標V正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool5R(int robot); // 工具座標V反向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool6P(int robot); // 工具座標W正向吋動
        [DllImport("HRSDK_x64.dll")]
        public static extern void jog_tool6R(int robot); // 工具座標W反向吋動
        #endregion

        // 3.4.2. 停止連續移動：(p. 38)
        [DllImport("HRSDK_x64.dll")]
        public static extern int jog_stop(int robot);

        // 3.4.3. 儲存教導點：(p.38)
        [DllImport("HRSDK_x64.dll")]
        public static extern int teach_point(int robot, int p);


        // 3.4.4. 取得教導點座標：(p. 38)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_teach_point_coordinate(int robot, int p, double[] coor);

        // 3.4.5. 取得教導點工具與基底編號：
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_teach_point_tool_local(int robot, int p, int[] ToolBase);
        #endregion
        
        #region 3.5. 參考命令 (p. 39)
        // 3.5.1. 取得目前位置：(p. 39)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_current_pos(int robot , int coorType, double[] coor);

        // 3.5.2. 取得目前關節座標(RG)：(p. 39)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_current_jointRG(int robot, double[] coor);

        // 3.5.3. 取得目前絕對座標(RG)：(p. 40)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_current_cartRG(int robot, double[] coor);

        // 3.5.4. 取得目前轉速：(p. 40)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_current_rpm(int robot, double[] motorRpm);

        // 3.5.5. 取得目前轉速(RG)：(p. 40)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_current_rpmRG(int robot, double[] coor);

        // 3.5.6. 取得佇列中命令數：(p. 41)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_com_countRG(int robot);

        // 3.5.7. 取得目前運動狀態：(p. 41)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_motion_status(int robot);

        // 3.5.8. 取得錯誤代碼：(p. 42)
        [DllImport("HRSDK_x64.dll")]
        public static extern int get_errCodeRG(int robot);

        // 3.5.9. 設定控制器IP：(p. 42)
        [DllImport("HRSDK_x64.dll")]
        public static extern int set_server_ip(int robot, int[] ip);

        // 3.5.10. 取得Robot Input值：(p. 43)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOInputValue(int robot);

        // 3.5.11. 取得Robot Input值(RG)：(p. 43)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOInputValueRG(int robot);

        // 3.5.12. 設定Robot Output值：(p. 44)
        [DllImport("HRSDK_x64.dll")]
        public static extern int SetRIOOutputValueByNumber(int robot, int on_off, int Ox);

        // 3.5.13. 取得Robot Output值：(p. 44)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOOutputValue(int robot);

        // 3.5.14. 取得Robot Output值(RG)：(p. 44)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOOutputValueRG(int robot);

        // 3.5.15. 設定Robot電磁閥Output：(p. 45)
        [DllImport("HRSDK_x64.dll")]
        public static extern int SetRIOVOutputValueByNumber(int robot, int on_off, int VOx);

        // 3.5.16. 取得Robot電磁閥Output：(p. 45)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOVOutputValue(int robot);

        //  3.5.17. 取得Robot電磁閥Output (RG)：(p. 45)
        [DllImport("HRSDK_x64.dll")]
        public static extern int GetRIOVOutputValueRG(int robot);

        // 3.5.18. 運動同步開關 Output：(p. 46)
        [DllImport("HRSDK_x64.dll")]
        public static extern int SyncOutput(int robot, int O_type, int O_id, int on_off, int synMode, int delay, int distance);
        #endregion
    }
}