using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLogEditor
{
    class Reference
    {
        enum Cause
        {
            Request_sensor_state,
            Execute_motor_profile,
            Sensor_Failed,
            Motor_Failed,
            Internal_Communication_Error,
            Multipick,
            NoPick,
            Controller_Failure,
            Voltage_Level_Failure_24v_36v,
            Power_Fuse_Fault,
            Internal_FW_downloading_progress,
            Internal_FW_downloading_failure,
            JetLink_Communication_error,
            NVRAM_failure,
            Test_mode_switch_active,
            Download_switch_active,
            Request_PTS_measurement,
            Voltage_level_failure_6v

        }

        enum Priority
        {
            Status,
            Warning,
            Intervention,
            Critical_Error
        }

        enum FeederMCUID6
        {
            Main_MCU,
            Feed_head_MCU_Drawer1,
            Air_flow_MCU_Drawer1,
            Retiming_MCU_Drawer1,
            Feed_head_MCU_Drawer2,
            Air_flow_MCU_Drawer2,
            Retiming_MCU_Drawer2,
            Feed_head_MCU_Drawer3,
            Air_flow_MCU_Drawer3,
            Retiming_MCU_Drawer3,
            Feed_head_MCU_Drawer4,
            Air_flow_MCU_Drawer4,
            Retiming_MCU_Drawer4,
            Bypass_MCU,
            Verticle_MCU,
            Multipick_MCU,
            Bridge_Trasport_MCU,
            Bridge_Alignment_MCU,
            Bridge_Transport_MCU,
            Measure_Board_MCU,
            Paper_Thickness_Sensor_PTS_unit
        }

        enum FeederMCUID4
        {
            Main_MCU,
            Drawer1_Feed_head_or_Bypass_MCU,
            Drawer1_Airflow_and_Exit_MCU,
            Bridge_enrty_MCU,
            Drawer2_Feed_head_MCU,
            Drawer2_Airflow_and_Exit_MCU,
            Bridge_Transport_and_Align_MCU,
            Drawer3_Feed_head_MCU,
            Drawer3_Airflow_and_Exit_MCU,
            Diverter_MCU,
            Drawer4_Feed_head_MCU,
            Drawer4_Airflow_and_Exit_MCU,
            Multi_pick_and_Verticle_MCU
        }

        enum MotorID
        {
            Drawer_lock1,
            Drawer_lock2,
            Drawer_lock3,
            Drawer_lock4,
            Vacuum_valve_motor1,
            Vacuum_valve_motor2,
            Vacuum_valve_motor3,
            Vacuum_valve_motor4,
            Blower_valve_motor1,
            Blower_valve_motor2,
            Blower_valve_motor3,
            Blower_valve_motor4,
            Drawer_Lift_motor1,
            Drawer_Lift_motor2,
            Drawer_Lift_motor3,
            Drawer_Lift_motor4,
        }
    }
}

